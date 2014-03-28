using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ImageCheck
{
    public partial class ImageCheckDialog : Form
    {
        static private string SaveFileName = ".imageCheck";

        #region Properties
        private bool isSelecting;
        private Color oldColor;

        private string _currentDirectory = "";
        private string CurrentDirectory { 
            get
            {
                return _currentDirectory;
            }
            set
            {
                if (value != _currentDirectory)
                {
                    _currentDirectory = value;
                    if (!string.IsNullOrEmpty(_currentDirectory))
                    {
                        this.Text = String.Format("{0}: {1}", 
                            Properties.Resources.ModuleName, 
                            _currentDirectory
                        );
                    }
                    else
                    {
                        this.Text = Properties.Resources.ModuleName;
                    }
                }
            }
        }

        private bool Changed { get; set; }
        #endregion

        #region Settings
        private bool ProceedOnDelete
        {
            get
            {
                return (bool)Properties.Settings.Default["ProceedOnDelete"];
            }
        }

        private bool DoQuickResume
        {
            get
            {
                return (bool)Properties.Settings.Default["QuickResume"];
            }
        }

        private bool DoStartFullSrceen
        {
            get
            {
                return (bool)Properties.Settings.Default["StartFullScreen"];
            }
        }

        private string LastDirectory
        {
            get
            {
                return Properties.Settings.Default["LastDirectory"].ToString();
            }
            set
            {
                if (Properties.Settings.Default["LastDirectory"].ToString() != value)
                {
                    Properties.Settings.Default["LastDirectory"] = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private static string LastFile
        {
            get
            {
                return Properties.Settings.Default["LastFile"].ToString();
            }
            set
            {
                if (Properties.Settings.Default["LastFile"].ToString() != value)
                {
                    Properties.Settings.Default["LastFile"] = value;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private bool SupressSaveQuestion
        {
            get
            {
                return (bool)Properties.Settings.Default["NoSaveQuestion"];
            }
        }

        private Color ControlBackColor
        {
            get
            {
                return (Color)Properties.Settings.Default["BackgroundColor"];
            }
            set
            {
                if ((Color)Properties.Settings.Default["BackgroundColor"] != value)
                {
                    Properties.Settings.Default["BackgroundColor"] = value;
                    Properties.Settings.Default.Save();
                    BackColor = value;
                }
            }
        }
        #endregion

        public ImageCheckDialog()
        {
            InitializeComponent();
        }

        #region Form Events
        private void ImageCheckDialog_Load(object sender, EventArgs e)
        {
            isSelecting = false;

            pbDeleteMark.Image = ImageCheck.Properties.Resources.deleted;
            pbDeleteMark.BackColor = Color.Transparent;
            pbDeleteMark.Parent = pictureBox1;
            pbDeleteMark.Visible = false;

            BackColor = ControlBackColor;

            if (DoQuickResume)
            {
                ResumeLastPosition();
            }
            else
            {
                bnResume.Enabled = !String.IsNullOrEmpty(LastDirectory);
            }

            if (DoStartFullSrceen)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ImageCheckDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckSaveAndContiune())
            {
                e.Cancel = true;
            }
            Properties.Settings.Default.Save();
        }

        private void ImageCheckDialog_Resize(object sender, EventArgs e)
        {
            RecalculateLayout();
        }

        private bool CheckSaveAndContiune()
        {
            System.Windows.Forms.DialogResult res = System.Windows.Forms.DialogResult.Yes;

            if (!SupressSaveQuestion && Changed)
            {
                res = MessageBox.Show("Current directory state has changed.\nSave changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }

            if (res == System.Windows.Forms.DialogResult.Cancel)
            {
                return false;
            }
            
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                SaveData();
            }
            return true;
        }

        private void ImageCheckDialog_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ImageFile imgFile = lbImages.SelectedItem as ImageFile;
                    if (imgFile != null)
                    {
                        imgFile.Deleted = !imgFile.Deleted;
                        pbDeleteMark.Visible = imgFile.Deleted;
                        Changed = true;
                        if (ProceedOnDelete && imgFile.Deleted)
                        {
                            ProceedToNextPicture();
                        }
                    }
                    break;
                case Keys.Right:
                case Keys.Down:
                case Keys.Space:
                    ProceedToNextPicture();
                    break;
                case Keys.Left:
                case Keys.Up:
                    ProceedToPreviousPicture();
                    break;
                case Keys.Home:
                    lbImages.SelectedIndex = 0;
                    break;
                case Keys.End:
                    lbImages.SelectedIndex = lbImages.Items.Count - 1;
                    break;
                case Keys.Escape:
                    Close();
                    break;
                default:
                    e.SuppressKeyPress = false;
                    break;
            }
        }
        #endregion

        #region Button Events

        private void bnDirectory_Click(object sender, EventArgs e)
        {
            if (CheckSaveAndContiune())
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.SelectedPath = CurrentDirectory;
                if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (dlg.SelectedPath != CurrentDirectory)
                    {
                        SetNewDirectory(dlg.SelectedPath);
                    }
                }
            }
        }

        private void bnErase_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult res = MessageBox.Show("All files marked for deletion will be erased.\nContinue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                EraseFiles();
            }
        }

        private void bnResume_Click(object sender, EventArgs e)
        {
            ResumeLastPosition();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (Changed)
            {
                SaveData();
            }
        }
        #endregion

        #region List Box Events

        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            ImageFile f = lb.SelectedItem as ImageFile;
            if (f != null)
            {
                LastFile = f.FileName;
            }
            else
            {
                pbDeleteMark.Visible = false;
            }
            LoadImage(f);
        }

        #endregion

        private void SetNewDirectory(string p)
        {
            if (String.IsNullOrEmpty(p))
            {
                return;
            }
            CurrentDirectory = p;
            LastDirectory = p;

            string f = Path.Combine(p, SaveFileName);
            List<string> deletedFiles = new List<string>();
            if (File.Exists(f))
            {
                string line;
                using (StreamReader r = new StreamReader(f))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        deletedFiles.Add(line);
                    }
                }
            }
            PopulateImageList(deletedFiles);
            Changed = false;

            pictureBox1.Focus();
        }

        private void PopulateImageList(List<string> deletedFiles)
        {
            Cursor.Current = Cursors.WaitCursor;

            lbImages.Items.Clear();
            List<string> fileNames = new List<string>();

            foreach (string ext in new String[] { "jpg", "jpeg", "gif", "png", "tif", "tiff", "bmp" })
            {
                foreach (string f in Directory.GetFiles(CurrentDirectory, String.Format("*.{0}", ext), System.IO.SearchOption.TopDirectoryOnly))
                {
                    fileNames.Add(f);  
                }
            }

            fileNames.Sort();
            int idx = 0;
            int foundAt = -1;

            foreach (string f in fileNames)
            {
                ImageFile img = new ImageFile(f);
                img.Deleted = deletedFiles.Contains(Path.GetFileName(f));
                lbImages.Items.Add(img);
                if (img.FileName == LastFile)
                {
                    foundAt = idx;
                }
                ++idx;
            }
            Cursor.Current = Cursors.Default;

            lbImages.SelectedIndex = foundAt;
        }

        private void LoadImage(ImageFile f)
        {
            Image img = null;
            if (f != null) {
                Cursor.Current = Cursors.WaitCursor;
                img = f.FileImage.Clone() as Image;
                Cursor.Current = Cursors.Default;

                pictureBox1.Image = img;
                pbDeleteMark.Visible = f.Deleted;

                RecalculateLayout();
            }
            pictureBox1.Image = img;
        }

        private void RecalculateLayout()
        {
            if (pictureBox1.Image == null)
            {
                return;
            }

            if (pictureBox1.Image.Width < pictureBox1.Width && pictureBox1.Image.Height < pictureBox1.Height)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pbDeleteMark.Location = new Point(
                    (pictureBox1.Width - pictureBox1.Image.Width) / 2 + pictureBox1.Image.Width - pbDeleteMark.Width - 2,
                    (pictureBox1.Height - pictureBox1.Image.Height) / 2 + pictureBox1.Image.Height - pbDeleteMark.Height - 2
                );
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                double ratioX = (double)pictureBox1.Width / (double)pictureBox1.Image.Width;
                double ratioY = (double)pictureBox1.Height / (double)pictureBox1.Image.Height;

                if (ratioX > ratioY)
                {
                    int newWidth = (int)((double)pictureBox1.Image.Width * ratioY);
                    pbDeleteMark.Location = new Point(
                        (pictureBox1.Width - newWidth) / 2 + newWidth - pbDeleteMark.Width - 2,
                        pictureBox1.Height - pbDeleteMark.Height - 2
                    );
                }
                else
                {
                    int newHeight = (int)((double)pictureBox1.Image.Height * ratioX);
                    pbDeleteMark.Location = new Point(
                        pictureBox1.Width - pbDeleteMark.Width - 2,
                        (pictureBox1.Height - newHeight) / 2 + newHeight - pbDeleteMark.Height - 2
                    );
                }
            }
        }

        private void ProceedToPreviousPicture()
        {
            if (lbImages.SelectedIndex > 0)
            {
                lbImages.SelectedIndex--;
            }
        }

        private void ProceedToNextPicture()
        {
            if (lbImages.SelectedIndex < lbImages.Items.Count - 1)
            {
                lbImages.SelectedIndex++;
            };
        }

        private void SaveData()
        {
            string fName = Path.Combine(CurrentDirectory, SaveFileName);
            using (StreamWriter wr = new StreamWriter(fName, false))
            {
                foreach (ImageFile img in lbImages.Items)
                {
                    if (img.Deleted)
                    {
                        wr.WriteLine(img.FileName);
                    }
                }
            }
            Changed = false;
        }

        private void EraseFiles()
        {
            lbImages.SelectedIndex = -1;

            foreach (ImageFile img in lbImages.Items) {
                if (img.Deleted)
                {
                    FileSystem.DeleteFile(img.FullFileName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
            }

            FileSystem.DeleteFile(Path.Combine(CurrentDirectory, SaveFileName), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);

            LastFile = "";

            SetNewDirectory(CurrentDirectory);
        }

        private void ResumeLastPosition()
        {
            SetNewDirectory(LastDirectory);
            bnResume.Enabled = false;
        }

        private void pbColorSelection_MouseDown(object sender, MouseEventArgs e)
        {
            isSelecting = true;
            oldColor = pictureBox1.BackColor;
        }

        private void pbColorSelection_MouseUp(object sender, MouseEventArgs e)
        {
            isSelecting = false;
        }

        private void pbColorSelection_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting == true)
            {
                Bitmap bmpImage = (Bitmap)pbColorSelection.Image;
                Color clr = oldColor;

                if ((0 < e.X && e.X < bmpImage.Width)
                    && (0 < e.Y && e.Y < bmpImage.Height))
                {
                    clr = bmpImage.GetPixel(e.X, e.Y);
                }

                ControlBackColor = clr;
            }
        }

        private void bnColorWhite_Click(object sender, EventArgs e)
        {
            ControlBackColor = System.Drawing.Color.White;
        }

        private void bnColorBlack_Click(object sender, EventArgs e)
        {
            ControlBackColor = System.Drawing.Color.Black;
        }

        private void bnColorControl_Click(object sender, EventArgs e)
        {
            ControlBackColor = SystemColors.Control;
        }
    }
}

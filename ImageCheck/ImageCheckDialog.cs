using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCheck
{
    public partial class ImageCheckDialog : Form
    {
        static private string SaveFileName = ".imageCheck";

        private bool Changed { get; set; }

        public ImageCheckDialog()
        {
            InitializeComponent();
        }

        private void ImageCheckDialog_Load(object sender, EventArgs e)
        {
            pbDeleteMark.Image = ImageCheck.Properties.Resources.deleted;
            pbDeleteMark.BackColor = Color.Transparent;
            pbDeleteMark.Parent = pictureBox1;
            pbDeleteMark.Visible = false;
        }

        private bool CheckSaveAndContiune()
        {
            if (Changed)
            {
                System.Windows.Forms.DialogResult res = MessageBox.Show("Current directory state has changed.\nSave changes?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (res == System.Windows.Forms.DialogResult.Cancel)
                {
                    return false;
                }
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveData();
                }
            }
            return true;
        }

        private void bnDirectory_Click(object sender, EventArgs e)
        {
            if (CheckSaveAndContiune())
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.SelectedPath = tbDirectory.Text;
                if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    if (dlg.SelectedPath != tbDirectory.Text)
                    {
                        SetNewDirectory(dlg.SelectedPath);
                    }
                }
            }
        }

        private void SetNewDirectory(string p)
        {
            if (String.IsNullOrEmpty(p))
            {
                return;
            }
            tbDirectory.Text = p;
            Properties.Settings.Default["LastDirectory"] = p;
            Properties.Settings.Default.Save();

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
                    r.Close();
                }
            }
            PopulateImageList(deletedFiles);
            Changed = false;
        }

        private void PopulateImageList(List<string> deletedFiles)
        {
            string lastFile = Properties.Settings.Default["LastFile"].ToString();

            lbImages.Items.Clear();
            List<string> fileNames = new List<string>();

            foreach (string ext in new String[] { "jpg", "jpeg", "gif", "png", "tif", "tiff", "bmp" })
            {
                foreach (string f in Directory.GetFiles(tbDirectory.Text, String.Format("*.{0}", ext), System.IO.SearchOption.TopDirectoryOnly))
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
                if (img.FileName == lastFile)
                {
                    foundAt = idx;
                }
                ++idx;
            }

            lbImages.SelectedIndex = foundAt;
        }

        private void lbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            ImageFile f = lb.SelectedItem as ImageFile;
            if (f != null)
            {
                Properties.Settings.Default["LastFile"] = f.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
                pbDeleteMark.Visible = false;
            }
            LoadImage(f);
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

        private void ImageCheckDialog_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    ImageFile imgFile = lbImages.SelectedItem as ImageFile;
                    if (imgFile != null)
                    {
                        imgFile.Deleted = !imgFile.Deleted;
                        pbDeleteMark.Visible = imgFile.Deleted;
                        Changed = true;
                    }
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Right:
                case Keys.Down:
                case Keys.Space:
                    if (lbImages.SelectedIndex < lbImages.Items.Count - 1) {
                        lbImages.SelectedIndex++;
                    };
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Left:
                case Keys.Up:
                    if (lbImages.SelectedIndex > 0)
                    {
                        lbImages.SelectedIndex--;
                    }
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Home:
                    lbImages.SelectedIndex = 0;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.End:
                    lbImages.SelectedIndex = lbImages.Items.Count - 1;
                    e.SuppressKeyPress = true;
                    break;
                case Keys.Escape:
                    Close();
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void bnSave_Click(object sender, EventArgs e)
        {
            if (Changed)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            string fName = Path.Combine(tbDirectory.Text, SaveFileName);
            using (StreamWriter wr = new StreamWriter(fName, false))
            {
                foreach (ImageFile img in lbImages.Items)
                {
                    if (img.Deleted)
                    {
                        wr.WriteLine(img.FileName);
                    }
                }
                wr.Close();
            }
            Changed = false;
        }

        private void ImageCheckDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckSaveAndContiune())
            {
                e.Cancel = true;
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

        private void EraseFiles()
        {
            lbImages.SelectedIndex = -1;

            foreach (ImageFile img in lbImages.Items) {
                if (img.Deleted)
                {
                    FileSystem.DeleteFile(img.FullFileName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                }
            }

            FileSystem.DeleteFile(Path.Combine(tbDirectory.Text, SaveFileName), UIOption.OnlyErrorDialogs, RecycleOption.DeletePermanently);

            Properties.Settings.Default["LastFile"] = "";
            Properties.Settings.Default.Save();

            SetNewDirectory(tbDirectory.Text);
        }

        private void ImageCheckDialog_Resize(object sender, EventArgs e)
        {
            RecalculateLayout();
        }

        private void bnResume_Click(object sender, EventArgs e)
        {
            string lastDir = Properties.Settings.Default["LastDirectory"].ToString();
            SetNewDirectory(lastDir);
        }
    }
}

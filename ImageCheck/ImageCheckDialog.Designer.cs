namespace ImageCheck
{
    partial class ImageCheckDialog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageCheckDialog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabImages = new System.Windows.Forms.TabPage();
            this.bnSave = new System.Windows.Forms.Button();
            this.bnResume = new System.Windows.Forms.Button();
            this.bnErase = new System.Windows.Forms.Button();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.bnDirectory = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.pbColorSelection = new System.Windows.Forms.PictureBox();
            this.pbDeleteMark = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttButtonTip = new System.Windows.Forms.ToolTip(this.components);
            this.bnColorWhite = new System.Windows.Forms.Button();
            this.bnColorBlack = new System.Windows.Forms.Button();
            this.bnColorControl = new System.Windows.Forms.Button();
            this.cbStartFullScreen = new System.Windows.Forms.CheckBox();
            this.cbSaveNoQuestions = new System.Windows.Forms.CheckBox();
            this.cbDeleteProceed = new System.Windows.Forms.CheckBox();
            this.cbQuickResume = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbDeleteMark);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 569);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabImages);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 2);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(135, 569);
            this.tabControl.TabIndex = 0;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.bnSave);
            this.tabImages.Controls.Add(this.bnResume);
            this.tabImages.Controls.Add(this.bnErase);
            this.tabImages.Controls.Add(this.lbImages);
            this.tabImages.Controls.Add(this.bnDirectory);
            this.tabImages.Location = new System.Drawing.Point(4, 20);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabImages.Size = new System.Drawing.Size(127, 545);
            this.tabImages.TabIndex = 0;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Image = global::ImageCheck.Properties.Resources.data;
            this.bnSave.Location = new System.Drawing.Point(65, 6);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(28, 28);
            this.bnSave.TabIndex = 8;
            this.bnSave.TabStop = false;
            this.ttButtonTip.SetToolTip(this.bnSave, "Save Data");
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // bnResume
            // 
            this.bnResume.Image = global::ImageCheck.Properties.Resources.Resume;
            this.bnResume.Location = new System.Drawing.Point(3, 6);
            this.bnResume.Name = "bnResume";
            this.bnResume.Size = new System.Drawing.Size(28, 28);
            this.bnResume.TabIndex = 7;
            this.bnResume.TabStop = false;
            this.ttButtonTip.SetToolTip(this.bnResume, "Resume Operation");
            this.bnResume.UseVisualStyleBackColor = true;
            this.bnResume.Click += new System.EventHandler(this.bnResume_Click);
            // 
            // bnErase
            // 
            this.bnErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnErase.Image = global::ImageCheck.Properties.Resources.bomb;
            this.bnErase.Location = new System.Drawing.Point(96, 6);
            this.bnErase.Name = "bnErase";
            this.bnErase.Size = new System.Drawing.Size(28, 28);
            this.bnErase.TabIndex = 6;
            this.bnErase.TabStop = false;
            this.ttButtonTip.SetToolTip(this.bnErase, "Erase Files");
            this.bnErase.UseVisualStyleBackColor = true;
            this.bnErase.Click += new System.EventHandler(this.bnErase_Click);
            // 
            // lbImages
            // 
            this.lbImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImages.FormattingEnabled = true;
            this.lbImages.Location = new System.Drawing.Point(3, 44);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(121, 498);
            this.lbImages.TabIndex = 0;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            // 
            // bnDirectory
            // 
            this.bnDirectory.Image = global::ImageCheck.Properties.Resources.folder;
            this.bnDirectory.Location = new System.Drawing.Point(34, 6);
            this.bnDirectory.Name = "bnDirectory";
            this.bnDirectory.Size = new System.Drawing.Size(28, 28);
            this.bnDirectory.TabIndex = 5;
            this.bnDirectory.TabStop = false;
            this.ttButtonTip.SetToolTip(this.bnDirectory, "Open Directory");
            this.bnDirectory.UseVisualStyleBackColor = true;
            this.bnDirectory.Click += new System.EventHandler(this.bnDirectory_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.bnColorControl);
            this.tabSettings.Controls.Add(this.bnColorBlack);
            this.tabSettings.Controls.Add(this.bnColorWhite);
            this.tabSettings.Controls.Add(this.pbColorSelection);
            this.tabSettings.Controls.Add(this.cbStartFullScreen);
            this.tabSettings.Controls.Add(this.cbSaveNoQuestions);
            this.tabSettings.Controls.Add(this.cbDeleteProceed);
            this.tabSettings.Controls.Add(this.cbQuickResume);
            this.tabSettings.Location = new System.Drawing.Point(4, 20);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(127, 545);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Control";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // pbColorSelection
            // 
            this.pbColorSelection.Image = global::ImageCheck.Properties.Resources.colorpal1;
            this.pbColorSelection.Location = new System.Drawing.Point(3, 150);
            this.pbColorSelection.Name = "pbColorSelection";
            this.pbColorSelection.Size = new System.Drawing.Size(120, 83);
            this.pbColorSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColorSelection.TabIndex = 4;
            this.pbColorSelection.TabStop = false;
            this.pbColorSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelection_MouseDown);
            this.pbColorSelection.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbColorSelection_MouseMove);
            this.pbColorSelection.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbColorSelection_MouseUp);
            // 
            // pbDeleteMark
            // 
            this.pbDeleteMark.BackColor = System.Drawing.Color.Transparent;
            this.pbDeleteMark.Location = new System.Drawing.Point(979, 508);
            this.pbDeleteMark.Name = "pbDeleteMark";
            this.pbDeleteMark.Size = new System.Drawing.Size(32, 32);
            this.pbDeleteMark.TabIndex = 1;
            this.pbDeleteMark.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bnColorWhite
            // 
            this.bnColorWhite.BackColor = System.Drawing.Color.White;
            this.bnColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnColorWhite.Location = new System.Drawing.Point(6, 239);
            this.bnColorWhite.Name = "bnColorWhite";
            this.bnColorWhite.Size = new System.Drawing.Size(109, 23);
            this.bnColorWhite.TabIndex = 5;
            this.bnColorWhite.Text = "White";
            this.bnColorWhite.UseVisualStyleBackColor = false;
            this.bnColorWhite.Click += new System.EventHandler(this.bnColorWhite_Click);
            // 
            // bnColorBlack
            // 
            this.bnColorBlack.BackColor = System.Drawing.Color.Black;
            this.bnColorBlack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnColorBlack.ForeColor = System.Drawing.Color.Snow;
            this.bnColorBlack.Location = new System.Drawing.Point(6, 268);
            this.bnColorBlack.Name = "bnColorBlack";
            this.bnColorBlack.Size = new System.Drawing.Size(109, 23);
            this.bnColorBlack.TabIndex = 6;
            this.bnColorBlack.Text = "Black";
            this.bnColorBlack.UseVisualStyleBackColor = false;
            this.bnColorBlack.Click += new System.EventHandler(this.bnColorBlack_Click);
            // 
            // bnColorControl
            // 
            this.bnColorControl.BackColor = System.Drawing.SystemColors.Control;
            this.bnColorControl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnColorControl.Location = new System.Drawing.Point(6, 297);
            this.bnColorControl.Name = "bnColorControl";
            this.bnColorControl.Size = new System.Drawing.Size(109, 23);
            this.bnColorControl.TabIndex = 7;
            this.bnColorControl.Text = "Control";
            this.bnColorControl.UseVisualStyleBackColor = false;
            this.bnColorControl.Click += new System.EventHandler(this.bnColorControl_Click);
            // 
            // cbStartFullScreen
            // 
            this.cbStartFullScreen.AutoSize = true;
            this.cbStartFullScreen.Checked = global::ImageCheck.Properties.Settings.Default.StartFullScreen;
            this.cbStartFullScreen.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageCheck.Properties.Settings.Default, "StartFullScreen", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbStartFullScreen.Location = new System.Drawing.Point(6, 103);
            this.cbStartFullScreen.Name = "cbStartFullScreen";
            this.cbStartFullScreen.Size = new System.Drawing.Size(104, 17);
            this.cbStartFullScreen.TabIndex = 3;
            this.cbStartFullScreen.Text = "Start Full Screen";
            this.cbStartFullScreen.UseVisualStyleBackColor = true;
            // 
            // cbSaveNoQuestions
            // 
            this.cbSaveNoQuestions.AutoSize = true;
            this.cbSaveNoQuestions.Checked = global::ImageCheck.Properties.Settings.Default.NoSaveQuestion;
            this.cbSaveNoQuestions.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageCheck.Properties.Settings.Default, "NoSaveQuestion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbSaveNoQuestions.Location = new System.Drawing.Point(6, 74);
            this.cbSaveNoQuestions.Name = "cbSaveNoQuestions";
            this.cbSaveNoQuestions.Size = new System.Drawing.Size(109, 17);
            this.cbSaveNoQuestions.TabIndex = 2;
            this.cbSaveNoQuestions.Text = "No save question";
            this.cbSaveNoQuestions.UseVisualStyleBackColor = true;
            // 
            // cbDeleteProceed
            // 
            this.cbDeleteProceed.AutoSize = true;
            this.cbDeleteProceed.Checked = global::ImageCheck.Properties.Settings.Default.ProceedOnDelete;
            this.cbDeleteProceed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleteProceed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageCheck.Properties.Settings.Default, "ProceedOnDelete", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbDeleteProceed.Location = new System.Drawing.Point(6, 45);
            this.cbDeleteProceed.Name = "cbDeleteProceed";
            this.cbDeleteProceed.Size = new System.Drawing.Size(107, 17);
            this.cbDeleteProceed.TabIndex = 1;
            this.cbDeleteProceed.Text = "Delete goto next ";
            this.cbDeleteProceed.UseVisualStyleBackColor = true;
            // 
            // cbQuickResume
            // 
            this.cbQuickResume.AutoSize = true;
            this.cbQuickResume.Checked = global::ImageCheck.Properties.Settings.Default.QuickResume;
            this.cbQuickResume.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ImageCheck.Properties.Settings.Default, "QuickResume", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbQuickResume.Location = new System.Drawing.Point(6, 16);
            this.cbQuickResume.Name = "cbQuickResume";
            this.cbQuickResume.Size = new System.Drawing.Size(91, 17);
            this.cbQuickResume.TabIndex = 0;
            this.cbQuickResume.Text = "Quick resume";
            this.cbQuickResume.UseVisualStyleBackColor = true;
            // 
            // ImageCheckDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 593);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ImageCheckDialog";
            this.Text = "ImageCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageCheckDialog_FormClosing);
            this.Load += new System.EventHandler(this.ImageCheckDialog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageCheckDialog_KeyDown);
            this.Resize += new System.EventHandler(this.ImageCheckDialog_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnDirectory;
        private System.Windows.Forms.PictureBox pbDeleteMark;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.CheckBox cbSaveNoQuestions;
        private System.Windows.Forms.CheckBox cbDeleteProceed;
        private System.Windows.Forms.CheckBox cbQuickResume;
        private System.Windows.Forms.CheckBox cbStartFullScreen;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Button bnResume;
        private System.Windows.Forms.Button bnErase;
        private System.Windows.Forms.ToolTip ttButtonTip;
        private System.Windows.Forms.PictureBox pbColorSelection;
        private System.Windows.Forms.Button bnColorControl;
        private System.Windows.Forms.Button bnColorBlack;
        private System.Windows.Forms.Button bnColorWhite;
    }
}


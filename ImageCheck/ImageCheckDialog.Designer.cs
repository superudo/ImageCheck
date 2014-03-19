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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.pbDeleteMark = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnErase = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.bnDirectory = new System.Windows.Forms.Button();
            this.bnResume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbImages);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbDeleteMark);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 528);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbImages
            // 
            this.lbImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImages.FormattingEnabled = true;
            this.lbImages.Location = new System.Drawing.Point(1, 3);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(131, 511);
            this.lbImages.TabIndex = 0;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            // 
            // pbDeleteMark
            // 
            this.pbDeleteMark.BackColor = System.Drawing.Color.Transparent;
            this.pbDeleteMark.Location = new System.Drawing.Point(995, 496);
            this.pbDeleteMark.Name = "pbDeleteMark";
            this.pbDeleteMark.Size = new System.Drawing.Size(32, 32);
            this.pbDeleteMark.TabIndex = 1;
            this.pbDeleteMark.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1011, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bnErase
            // 
            this.bnErase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnErase.Location = new System.Drawing.Point(1087, 11);
            this.bnErase.Name = "bnErase";
            this.bnErase.Size = new System.Drawing.Size(75, 23);
            this.bnErase.TabIndex = 2;
            this.bnErase.Text = "Erase it!";
            this.bnErase.UseVisualStyleBackColor = true;
            this.bnErase.Click += new System.EventHandler(this.bnErase_Click);
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Location = new System.Drawing.Point(1006, 11);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(75, 23);
            this.bnSave.TabIndex = 3;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirectory.Location = new System.Drawing.Point(175, 12);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(825, 20);
            this.tbDirectory.TabIndex = 4;
            // 
            // bnDirectory
            // 
            this.bnDirectory.Location = new System.Drawing.Point(94, 9);
            this.bnDirectory.Name = "bnDirectory";
            this.bnDirectory.Size = new System.Drawing.Size(75, 23);
            this.bnDirectory.TabIndex = 5;
            this.bnDirectory.Text = "Select...";
            this.bnDirectory.UseVisualStyleBackColor = true;
            this.bnDirectory.Click += new System.EventHandler(this.bnDirectory_Click);
            // 
            // bnResume
            // 
            this.bnResume.Location = new System.Drawing.Point(13, 9);
            this.bnResume.Name = "bnResume";
            this.bnResume.Size = new System.Drawing.Size(75, 23);
            this.bnResume.TabIndex = 6;
            this.bnResume.Text = "Resume";
            this.bnResume.UseVisualStyleBackColor = true;
            this.bnResume.Click += new System.EventHandler(this.bnResume_Click);
            // 
            // ImageCheckDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 581);
            this.Controls.Add(this.bnResume);
            this.Controls.Add(this.bnDirectory);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.bnErase);
            this.Controls.Add(this.splitContainer1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnErase;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Button bnDirectory;
        private System.Windows.Forms.PictureBox pbDeleteMark;
        private System.Windows.Forms.Button bnResume;
    }
}


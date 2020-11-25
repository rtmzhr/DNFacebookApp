namespace DN_EX1
{
    partial class AlbumsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_AlbumsNamesListBox = new System.Windows.Forms.ListBox();
            this.m_CurrentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.m_NextPhoto = new System.Windows.Forms.Button();
            this.m_PreviousPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_CurrentPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_AlbumsNamesListBox
            // 
            this.m_AlbumsNamesListBox.FormattingEnabled = true;
            this.m_AlbumsNamesListBox.Location = new System.Drawing.Point(10, 14);
            this.m_AlbumsNamesListBox.Name = "m_AlbumsNamesListBox";
            this.m_AlbumsNamesListBox.Size = new System.Drawing.Size(778, 121);
            this.m_AlbumsNamesListBox.TabIndex = 0;
            // 
            // m_CurrentPhotoPictureBox
            // 
            this.m_CurrentPhotoPictureBox.Location = new System.Drawing.Point(206, 141);
            this.m_CurrentPhotoPictureBox.Name = "m_CurrentPhotoPictureBox";
            this.m_CurrentPhotoPictureBox.Size = new System.Drawing.Size(407, 279);
            this.m_CurrentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_CurrentPhotoPictureBox.TabIndex = 1;
            this.m_CurrentPhotoPictureBox.TabStop = false;
            // 
            // m_NextPhoto
            // 
            this.m_NextPhoto.Location = new System.Drawing.Point(638, 262);
            this.m_NextPhoto.Name = "m_NextPhoto";
            this.m_NextPhoto.Size = new System.Drawing.Size(66, 44);
            this.m_NextPhoto.TabIndex = 2;
            this.m_NextPhoto.Text = ">";
            this.m_NextPhoto.UseVisualStyleBackColor = true;
            this.m_NextPhoto.Click += new System.EventHandler(this.m_NextPhoto_Click);
            // 
            // m_PreviousPhoto
            // 
            this.m_PreviousPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.m_PreviousPhoto.Location = new System.Drawing.Point(105, 262);
            this.m_PreviousPhoto.Name = "m_PreviousPhoto";
            this.m_PreviousPhoto.Size = new System.Drawing.Size(66, 44);
            this.m_PreviousPhoto.TabIndex = 3;
            this.m_PreviousPhoto.Text = "<";
            this.m_PreviousPhoto.UseVisualStyleBackColor = true;
            this.m_PreviousPhoto.Click += new System.EventHandler(this.m_PreviousPhoto_Click);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_PreviousPhoto);
            this.Controls.Add(this.m_NextPhoto);
            this.Controls.Add(this.m_CurrentPhotoPictureBox);
            this.Controls.Add(this.m_AlbumsNamesListBox);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_CurrentPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox m_AlbumsNamesListBox;
        private System.Windows.Forms.PictureBox m_CurrentPhotoPictureBox;
        private System.Windows.Forms.Button m_NextPhoto;
        private System.Windows.Forms.Button m_PreviousPhoto;
    }
}
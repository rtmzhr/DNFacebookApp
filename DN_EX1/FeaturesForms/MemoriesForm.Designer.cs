namespace DN_EX1
{
    partial class MemoriesForm
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
            this.m_DateRadioButton = new System.Windows.Forms.RadioButton();
            this.m_FriendRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.m_FriendsListBox = new System.Windows.Forms.ListBox();
            this.m_Posts = new System.Windows.Forms.ListBox();
            this.m_PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.m_LeftPhoto = new System.Windows.Forms.Button();
            this.m_RightPhoto = new System.Windows.Forms.Button();
            this.m_PlacesCheckedInListBox = new System.Windows.Forms.ListBox();
            this.m_NumberOfPhotosLabal = new System.Windows.Forms.Label();
            this.m_EventsListBox = new System.Windows.Forms.ListBox();
            this.m_PostsLabel = new System.Windows.Forms.Label();
            this.m_PictureLabel = new System.Windows.Forms.Label();
            this.m_PlacesLabel = new System.Windows.Forms.Label();
            this.m_EventsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_DateRadioButton
            // 
            this.m_DateRadioButton.AutoSize = true;
            this.m_DateRadioButton.Location = new System.Drawing.Point(24, 60);
            this.m_DateRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_DateRadioButton.Name = "m_DateRadioButton";
            this.m_DateRadioButton.Size = new System.Drawing.Size(88, 29);
            this.m_DateRadioButton.TabIndex = 0;
            this.m_DateRadioButton.TabStop = true;
            this.m_DateRadioButton.Text = "Date";
            this.m_DateRadioButton.UseVisualStyleBackColor = true;
            this.m_DateRadioButton.CheckedChanged += new System.EventHandler(this.m_DateRadioButton_CheckedChanged);
            // 
            // m_FriendRadioButton
            // 
            this.m_FriendRadioButton.AutoSize = true;
            this.m_FriendRadioButton.Location = new System.Drawing.Point(24, 104);
            this.m_FriendRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_FriendRadioButton.Name = "m_FriendRadioButton";
            this.m_FriendRadioButton.Size = new System.Drawing.Size(104, 29);
            this.m_FriendRadioButton.TabIndex = 1;
            this.m_FriendRadioButton.TabStop = true;
            this.m_FriendRadioButton.Text = "Friend";
            this.m_FriendRadioButton.UseVisualStyleBackColor = true;
            this.m_FriendRadioButton.CheckedChanged += new System.EventHandler(this.m_FriendRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "See memories by:";
            // 
            // m_DatePicker
            // 
            this.m_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_DatePicker.Location = new System.Drawing.Point(234, 60);
            this.m_DatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.m_DatePicker.Name = "m_DatePicker";
            this.m_DatePicker.Size = new System.Drawing.Size(688, 31);
            this.m_DatePicker.TabIndex = 3;
            this.m_DatePicker.Value = new System.DateTime(2020, 11, 24, 14, 37, 0, 0);
            this.m_DatePicker.Visible = false;
            // 
            // m_FriendsListBox
            // 
            this.m_FriendsListBox.FormattingEnabled = true;
            this.m_FriendsListBox.ItemHeight = 25;
            this.m_FriendsListBox.Location = new System.Drawing.Point(234, 110);
            this.m_FriendsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.m_FriendsListBox.Name = "m_FriendsListBox";
            this.m_FriendsListBox.Size = new System.Drawing.Size(700, 29);
            this.m_FriendsListBox.TabIndex = 4;
            this.m_FriendsListBox.Visible = false;
            // 
            // m_Posts
            // 
            this.m_Posts.FormattingEnabled = true;
            this.m_Posts.ItemHeight = 25;
            this.m_Posts.Location = new System.Drawing.Point(24, 210);
            this.m_Posts.Margin = new System.Windows.Forms.Padding(6);
            this.m_Posts.Name = "m_Posts";
            this.m_Posts.Size = new System.Drawing.Size(654, 329);
            this.m_Posts.TabIndex = 5;
            // 
            // m_PhotoPictureBox
            // 
            this.m_PhotoPictureBox.Location = new System.Drawing.Point(948, 212);
            this.m_PhotoPictureBox.Name = "m_PhotoPictureBox";
            this.m_PhotoPictureBox.Size = new System.Drawing.Size(420, 326);
            this.m_PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PhotoPictureBox.TabIndex = 6;
            this.m_PhotoPictureBox.TabStop = false;
            // 
            // m_LeftPhoto
            // 
            this.m_LeftPhoto.Location = new System.Drawing.Point(836, 344);
            this.m_LeftPhoto.Name = "m_LeftPhoto";
            this.m_LeftPhoto.Size = new System.Drawing.Size(115, 82);
            this.m_LeftPhoto.TabIndex = 7;
            this.m_LeftPhoto.Text = "<";
            this.m_LeftPhoto.UseVisualStyleBackColor = true;
            this.m_LeftPhoto.Click += new System.EventHandler(this.m_LeftPhoto_Click);
            // 
            // m_RightPhoto
            // 
            this.m_RightPhoto.Location = new System.Drawing.Point(1362, 344);
            this.m_RightPhoto.Name = "m_RightPhoto";
            this.m_RightPhoto.Size = new System.Drawing.Size(115, 82);
            this.m_RightPhoto.TabIndex = 8;
            this.m_RightPhoto.Text = ">";
            this.m_RightPhoto.UseVisualStyleBackColor = true;
            this.m_RightPhoto.Click += new System.EventHandler(this.m_RightPhoto_Click);
            // 
            // m_PlacesCheckedInListBox
            // 
            this.m_PlacesCheckedInListBox.FormattingEnabled = true;
            this.m_PlacesCheckedInListBox.ItemHeight = 25;
            this.m_PlacesCheckedInListBox.Location = new System.Drawing.Point(24, 590);
            this.m_PlacesCheckedInListBox.Name = "m_PlacesCheckedInListBox";
            this.m_PlacesCheckedInListBox.Size = new System.Drawing.Size(598, 229);
            this.m_PlacesCheckedInListBox.TabIndex = 9;
            // 
            // m_NumberOfPhotosLabal
            // 
            this.m_NumberOfPhotosLabal.AutoSize = true;
            this.m_NumberOfPhotosLabal.Location = new System.Drawing.Point(950, 544);
            this.m_NumberOfPhotosLabal.Name = "m_NumberOfPhotosLabal";
            this.m_NumberOfPhotosLabal.Size = new System.Drawing.Size(70, 25);
            this.m_NumberOfPhotosLabal.TabIndex = 10;
            this.m_NumberOfPhotosLabal.Text = "label2";
            this.m_NumberOfPhotosLabal.Visible = false;
            // 
            // m_EventsListBox
            // 
            this.m_EventsListBox.FormattingEnabled = true;
            this.m_EventsListBox.ItemHeight = 25;
            this.m_EventsListBox.Location = new System.Drawing.Point(775, 632);
            this.m_EventsListBox.Name = "m_EventsListBox";
            this.m_EventsListBox.Size = new System.Drawing.Size(718, 204);
            this.m_EventsListBox.TabIndex = 11;
            // 
            // m_PostsLabel
            // 
            this.m_PostsLabel.AutoSize = true;
            this.m_PostsLabel.Location = new System.Drawing.Point(34, 179);
            this.m_PostsLabel.Name = "m_PostsLabel";
            this.m_PostsLabel.Size = new System.Drawing.Size(70, 25);
            this.m_PostsLabel.TabIndex = 12;
            this.m_PostsLabel.Text = "label2";
            // 
            // m_PictureLabel
            // 
            this.m_PictureLabel.AutoSize = true;
            this.m_PictureLabel.Location = new System.Drawing.Point(953, 179);
            this.m_PictureLabel.Name = "m_PictureLabel";
            this.m_PictureLabel.Size = new System.Drawing.Size(70, 25);
            this.m_PictureLabel.TabIndex = 13;
            this.m_PictureLabel.Text = "label3";
            // 
            // m_PlacesLabel
            // 
            this.m_PlacesLabel.AutoSize = true;
            this.m_PlacesLabel.Location = new System.Drawing.Point(12, 562);
            this.m_PlacesLabel.Name = "m_PlacesLabel";
            this.m_PlacesLabel.Size = new System.Drawing.Size(70, 25);
            this.m_PlacesLabel.TabIndex = 14;
            this.m_PlacesLabel.Text = "label4";
            // 
            // m_EventsLabel
            // 
            this.m_EventsLabel.AutoSize = true;
            this.m_EventsLabel.Location = new System.Drawing.Point(782, 604);
            this.m_EventsLabel.Name = "m_EventsLabel";
            this.m_EventsLabel.Size = new System.Drawing.Size(70, 25);
            this.m_EventsLabel.TabIndex = 15;
            this.m_EventsLabel.Text = "label5";
            // 
            // MemoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.m_EventsLabel);
            this.Controls.Add(this.m_PlacesLabel);
            this.Controls.Add(this.m_PictureLabel);
            this.Controls.Add(this.m_PostsLabel);
            this.Controls.Add(this.m_EventsListBox);
            this.Controls.Add(this.m_NumberOfPhotosLabal);
            this.Controls.Add(this.m_PlacesCheckedInListBox);
            this.Controls.Add(this.m_RightPhoto);
            this.Controls.Add(this.m_LeftPhoto);
            this.Controls.Add(this.m_PhotoPictureBox);
            this.Controls.Add(this.m_Posts);
            this.Controls.Add(this.m_FriendsListBox);
            this.Controls.Add(this.m_DatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_FriendRadioButton);
            this.Controls.Add(this.m_DateRadioButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MemoriesForm";
            this.Text = "Memories";
            ((System.ComponentModel.ISupportInitialize)(this.m_PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton m_DateRadioButton;
        private System.Windows.Forms.RadioButton m_FriendRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker m_DatePicker;
        private System.Windows.Forms.ListBox m_FriendsListBox;
        private System.Windows.Forms.ListBox m_Posts;
        private System.Windows.Forms.PictureBox m_PhotoPictureBox;
        private System.Windows.Forms.Button m_LeftPhoto;
        private System.Windows.Forms.Button m_RightPhoto;
        private System.Windows.Forms.ListBox m_PlacesCheckedInListBox;
        private System.Windows.Forms.Label m_NumberOfPhotosLabal;
        private System.Windows.Forms.ListBox m_EventsListBox;
        private System.Windows.Forms.Label m_PostsLabel;
        private System.Windows.Forms.Label m_PictureLabel;
        private System.Windows.Forms.Label m_PlacesLabel;
        private System.Windows.Forms.Label m_EventsLabel;
    }
}
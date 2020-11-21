
namespace DN_EX1
{
    partial class MainForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.newPostTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.aboutListBox = new System.Windows.Forms.ListBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.friendsListLabel = new System.Windows.Forms.Label();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.m_Collage = new DN_EX1.Collage();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(711, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(104, 51);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(29, 12);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(143, 114);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // newPostTextBox
            // 
            this.newPostTextBox.Location = new System.Drawing.Point(266, 186);
            this.newPostTextBox.Multiline = true;
            this.newPostTextBox.Name = "newPostTextBox";
            this.newPostTextBox.Size = new System.Drawing.Size(439, 97);
            this.newPostTextBox.TabIndex = 2;
            this.newPostTextBox.Text = "What\'s on your mind?";
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(711, 253);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(80, 30);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "POST";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // aboutListBox
            // 
            this.aboutListBox.FormattingEnabled = true;
            this.aboutListBox.ItemHeight = 20;
            this.aboutListBox.Location = new System.Drawing.Point(192, 32);
            this.aboutListBox.Name = "aboutListBox";
            this.aboutListBox.Size = new System.Drawing.Size(315, 104);
            this.aboutListBox.TabIndex = 4;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(29, 177);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(193, 124);
            this.friendsListBox.TabIndex = 7;
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 20;
            this.postsListBox.Location = new System.Drawing.Point(266, 329);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(549, 124);
            this.postsListBox.TabIndex = 8;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(188, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(127, 20);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "##WELCOME##";
            // 
            // friendsListLabel
            // 
            this.friendsListLabel.AutoSize = true;
            this.friendsListLabel.Location = new System.Drawing.Point(45, 154);
            this.friendsListLabel.Name = "friendsListLabel";
            this.friendsListLabel.Size = new System.Drawing.Size(91, 20);
            this.friendsListLabel.TabIndex = 10;
            this.friendsListLabel.Text = "Friends List";
            // 
            // albumsLabel
            // 
            this.albumsLabel.AutoSize = true;
            this.albumsLabel.Location = new System.Drawing.Point(45, 334);
            this.albumsLabel.Name = "albumsLabel";
            this.albumsLabel.Size = new System.Drawing.Size(62, 20);
            this.albumsLabel.TabIndex = 13;
            this.albumsLabel.Text = "Albums";
            // 
            // m_Collage
            // 
            this.m_Collage.Location = new System.Drawing.Point(29, 357);
            this.m_Collage.Name = "m_Collage";
            this.m_Collage.Size = new System.Drawing.Size(193, 124);
            this.m_Collage.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 512);
            this.Controls.Add(this.albumsLabel);
            this.Controls.Add(this.m_Collage);
            this.Controls.Add(this.friendsListLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.aboutListBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.newPostTextBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.logoutButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox newPostTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ListBox aboutListBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label friendsListLabel;
        private System.Windows.Forms.Label albumsLabel;
        private Collage m_Collage = new Collage();
    }
}
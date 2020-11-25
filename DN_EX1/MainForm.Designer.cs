
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_NewPostTextBox = new System.Windows.Forms.TextBox();
            this.m_PostsListBox = new System.Windows.Forms.ListBox();
            this.m_WelcomeLabel = new System.Windows.Forms.Label();
            this.m_AlbumsButton = new System.Windows.Forms.Button();
            this.m_MemoriesButton = new System.Windows.Forms.Button();
            this.m_FriendsButton = new System.Windows.Forms.Button();
            this.m_UserInfoButton = new System.Windows.Forms.Button();
            this.m_EventButton = new System.Windows.Forms.Button();
            this.m_PostButton = new System.Windows.Forms.Button();
            this.m_ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.m_LogoutButton = new System.Windows.Forms.Button();
            this.m_CoverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.m_FetchPostsButton = new System.Windows.Forms.Button();
            this.m_ShowPostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_NewPostTextBox
            // 
            this.m_NewPostTextBox.Location = new System.Drawing.Point(346, 421);
            this.m_NewPostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_NewPostTextBox.Multiline = true;
            this.m_NewPostTextBox.Name = "m_NewPostTextBox";
            this.m_NewPostTextBox.Size = new System.Drawing.Size(584, 119);
            this.m_NewPostTextBox.TabIndex = 2;
            this.m_NewPostTextBox.Text = "What\'s on your mind?";
            // 
            // m_PostsListBox
            // 
            this.m_PostsListBox.FormattingEnabled = true;
            this.m_PostsListBox.ItemHeight = 25;
            this.m_PostsListBox.Location = new System.Drawing.Point(346, 642);
            this.m_PostsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostsListBox.Name = "m_PostsListBox";
            this.m_PostsListBox.Size = new System.Drawing.Size(730, 154);
            this.m_PostsListBox.TabIndex = 8;
            // 
            // m_WelcomeLabel
            // 
            this.m_WelcomeLabel.AutoSize = true;
            this.m_WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_WelcomeLabel.Location = new System.Drawing.Point(-6, 312);
            this.m_WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_WelcomeLabel.Name = "m_WelcomeLabel";
            this.m_WelcomeLabel.Size = new System.Drawing.Size(326, 46);
            this.m_WelcomeLabel.TabIndex = 9;
            this.m_WelcomeLabel.Text = "##WELCOME##";
            // 
            // m_AlbumsButton
            // 
            this.m_AlbumsButton.Location = new System.Drawing.Point(2, 730);
            this.m_AlbumsButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_AlbumsButton.Name = "m_AlbumsButton";
            this.m_AlbumsButton.Size = new System.Drawing.Size(234, 48);
            this.m_AlbumsButton.TabIndex = 19;
            this.m_AlbumsButton.Text = "Albums";
            this.m_AlbumsButton.UseVisualStyleBackColor = true;
            this.m_AlbumsButton.Click += new System.EventHandler(this.albumsButton_Click);
            // 
            // m_MemoriesButton
            // 
            this.m_MemoriesButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_21_51_PM;
            this.m_MemoriesButton.Location = new System.Drawing.Point(2, 612);
            this.m_MemoriesButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_MemoriesButton.Name = "m_MemoriesButton";
            this.m_MemoriesButton.Size = new System.Drawing.Size(268, 85);
            this.m_MemoriesButton.TabIndex = 18;
            this.m_MemoriesButton.UseVisualStyleBackColor = true;
            this.m_MemoriesButton.Click += new System.EventHandler(this.memoryButton_Click);
            // 
            // m_FriendsButton
            // 
            this.m_FriendsButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_14_PM;
            this.m_FriendsButton.Location = new System.Drawing.Point(2, 490);
            this.m_FriendsButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_FriendsButton.Name = "m_FriendsButton";
            this.m_FriendsButton.Size = new System.Drawing.Size(216, 85);
            this.m_FriendsButton.TabIndex = 16;
            this.m_FriendsButton.UseVisualStyleBackColor = true;
            this.m_FriendsButton.Click += new System.EventHandler(this.friendsButton_Click);
            // 
            // m_UserInfoButton
            // 
            this.m_UserInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_UserInfoButton.BackgroundImage")));
            this.m_UserInfoButton.Location = new System.Drawing.Point(112, 198);
            this.m_UserInfoButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_UserInfoButton.Name = "m_UserInfoButton";
            this.m_UserInfoButton.Size = new System.Drawing.Size(78, 79);
            this.m_UserInfoButton.TabIndex = 15;
            this.m_UserInfoButton.UseVisualStyleBackColor = true;
            this.m_UserInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // m_EventButton
            // 
            this.m_EventButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_11_42_PM;
            this.m_EventButton.Location = new System.Drawing.Point(2, 415);
            this.m_EventButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_EventButton.Name = "m_EventButton";
            this.m_EventButton.Size = new System.Drawing.Size(216, 63);
            this.m_EventButton.TabIndex = 14;
            this.m_EventButton.UseVisualStyleBackColor = true;
            this.m_EventButton.Click += new System.EventHandler(this.findEventButton_Click);
            // 
            // m_PostButton
            // 
            this.m_PostButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_01_PM;
            this.m_PostButton.Location = new System.Drawing.Point(944, 490);
            this.m_PostButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostButton.Name = "m_PostButton";
            this.m_PostButton.Size = new System.Drawing.Size(150, 54);
            this.m_PostButton.TabIndex = 3;
            this.m_PostButton.UseVisualStyleBackColor = true;
            this.m_PostButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // m_ProfilePictureBox
            // 
            this.m_ProfilePictureBox.Location = new System.Drawing.Point(2, 106);
            this.m_ProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_ProfilePictureBox.Name = "m_ProfilePictureBox";
            this.m_ProfilePictureBox.Size = new System.Drawing.Size(190, 171);
            this.m_ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ProfilePictureBox.TabIndex = 1;
            this.m_ProfilePictureBox.TabStop = false;
            this.m_ProfilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_13_55_PM;
            this.m_LogoutButton.Location = new System.Drawing.Point(1122, 146);
            this.m_LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(110, 131);
            this.m_LogoutButton.TabIndex = 0;
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // m_CoverPhotoPictureBox
            // 
            this.m_CoverPhotoPictureBox.Location = new System.Drawing.Point(2, -4);
            this.m_CoverPhotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_CoverPhotoPictureBox.Name = "m_CoverPhotoPictureBox";
            this.m_CoverPhotoPictureBox.Size = new System.Drawing.Size(1230, 283);
            this.m_CoverPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_CoverPhotoPictureBox.TabIndex = 20;
            this.m_CoverPhotoPictureBox.TabStop = false;
            // 
            // m_FetchPostsButton
            // 
            this.m_FetchPostsButton.Location = new System.Drawing.Point(1083, 730);
            this.m_FetchPostsButton.Name = "m_FetchPostsButton";
            this.m_FetchPostsButton.Size = new System.Drawing.Size(125, 66);
            this.m_FetchPostsButton.TabIndex = 21;
            this.m_FetchPostsButton.Text = "Fetch Posts";
            this.m_FetchPostsButton.UseVisualStyleBackColor = true;
            this.m_FetchPostsButton.Click += new System.EventHandler(this.fetchPostsButton_Click);
            // 
            // m_ShowPostButton
            // 
            this.m_ShowPostButton.Location = new System.Drawing.Point(1083, 642);
            this.m_ShowPostButton.Name = "m_ShowPostButton";
            this.m_ShowPostButton.Size = new System.Drawing.Size(125, 66);
            this.m_ShowPostButton.TabIndex = 22;
            this.m_ShowPostButton.Text = "Show Post";
            this.m_ShowPostButton.UseVisualStyleBackColor = true;
            this.m_ShowPostButton.Click += new System.EventHandler(this.showPostButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 846);
            this.Controls.Add(this.m_ShowPostButton);
            this.Controls.Add(this.m_FetchPostsButton);
            this.Controls.Add(this.m_AlbumsButton);
            this.Controls.Add(this.m_MemoriesButton);
            this.Controls.Add(this.m_FriendsButton);
            this.Controls.Add(this.m_UserInfoButton);
            this.Controls.Add(this.m_EventButton);
            this.Controls.Add(this.m_WelcomeLabel);
            this.Controls.Add(this.m_PostsListBox);
            this.Controls.Add(this.m_PostButton);
            this.Controls.Add(this.m_NewPostTextBox);
            this.Controls.Add(this.m_ProfilePictureBox);
            this.Controls.Add(this.m_LogoutButton);
            this.Controls.Add(this.m_CoverPhotoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_LogoutButton;
        private System.Windows.Forms.TextBox m_NewPostTextBox;
        private System.Windows.Forms.Button m_PostButton;
        private System.Windows.Forms.ListBox m_PostsListBox;
        private System.Windows.Forms.Label m_WelcomeLabel;
        private System.Windows.Forms.PictureBox m_ProfilePictureBox;
        private System.Windows.Forms.Button m_EventButton;
        private System.Windows.Forms.Button m_UserInfoButton;
        private System.Windows.Forms.Button m_FriendsButton;
        private System.Windows.Forms.Button m_MemoriesButton;
        private System.Windows.Forms.Button m_AlbumsButton;
        private System.Windows.Forms.PictureBox m_CoverPhotoPictureBox;
        private System.Windows.Forms.Button m_FetchPostsButton;
        private System.Windows.Forms.Button m_ShowPostButton;
    }
}
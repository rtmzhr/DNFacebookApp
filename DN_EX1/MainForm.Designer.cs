
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
            this.newPostTextBox = new System.Windows.Forms.TextBox();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_FriendsButton = new System.Windows.Forms.Button();
            this.m_UserInfoButton = new System.Windows.Forms.Button();
            this.findEventButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.m_AlbumsButton = new System.Windows.Forms.Button();
            this.m_CoverPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.m_Collage = new DN_EX1.Collage();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newPostTextBox
            // 
            this.newPostTextBox.Location = new System.Drawing.Point(231, 270);
            this.newPostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPostTextBox.Multiline = true;
            this.newPostTextBox.Name = "newPostTextBox";
            this.newPostTextBox.Size = new System.Drawing.Size(391, 78);
            this.newPostTextBox.TabIndex = 2;
            this.newPostTextBox.Text = "What\'s on your mind?";
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 16;
            this.postsListBox.Location = new System.Drawing.Point(231, 411);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(488, 100);
            this.postsListBox.TabIndex = 8;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(-4, 200);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(172, 25);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "##WELCOME##";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_21_51_PM;
            this.button3.Location = new System.Drawing.Point(1, 441);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 54);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_16_32_PM;
            this.button2.Location = new System.Drawing.Point(1, 375);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 54);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_FriendsButton
            // 
            this.m_FriendsButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_14_PM;
            this.m_FriendsButton.Location = new System.Drawing.Point(1, 314);
            this.m_FriendsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_FriendsButton.Name = "m_FriendsButton";
            this.m_FriendsButton.Size = new System.Drawing.Size(144, 54);
            this.m_FriendsButton.TabIndex = 16;
            this.m_FriendsButton.UseVisualStyleBackColor = true;
            this.m_FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // m_UserInfoButton
            // 
            this.m_UserInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_UserInfoButton.BackgroundImage")));
            this.m_UserInfoButton.Location = new System.Drawing.Point(75, 127);
            this.m_UserInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_UserInfoButton.Name = "m_UserInfoButton";
            this.m_UserInfoButton.Size = new System.Drawing.Size(52, 50);
            this.m_UserInfoButton.TabIndex = 15;
            this.m_UserInfoButton.UseVisualStyleBackColor = true;
            this.m_UserInfoButton.Click += new System.EventHandler(this.m_UserInfoButton_Click);
            // 
            // findEventButton
            // 
            this.findEventButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_11_42_PM;
            this.findEventButton.Location = new System.Drawing.Point(1, 266);
            this.findEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findEventButton.Name = "findEventButton";
            this.findEventButton.Size = new System.Drawing.Size(144, 41);
            this.findEventButton.TabIndex = 14;
            this.findEventButton.UseVisualStyleBackColor = true;
            this.findEventButton.Click += new System.EventHandler(this.findEventButton_Click);
            // 
            // postButton
            // 
            this.postButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_01_PM;
            this.postButton.Location = new System.Drawing.Point(629, 314);
            this.postButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(100, 34);
            this.postButton.TabIndex = 3;
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(1, 68);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(127, 110);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_13_55_PM;
            this.logoutButton.Location = new System.Drawing.Point(748, 94);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(73, 84);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // m_AlbumsButton
            // 
            this.m_AlbumsButton.Location = new System.Drawing.Point(1, 502);
            this.m_AlbumsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_AlbumsButton.Name = "m_AlbumsButton";
            this.m_AlbumsButton.Size = new System.Drawing.Size(156, 31);
            this.m_AlbumsButton.TabIndex = 19;
            this.m_AlbumsButton.Text = "Albums";
            this.m_AlbumsButton.UseVisualStyleBackColor = true;
            this.m_AlbumsButton.Click += new System.EventHandler(this.m_AlbumsButton_Click);
            // 
            // m_CoverPhotoPictureBox
            // 
            this.m_CoverPhotoPictureBox.Location = new System.Drawing.Point(1, -3);
            this.m_CoverPhotoPictureBox.Name = "m_CoverPhotoPictureBox";
            this.m_CoverPhotoPictureBox.Size = new System.Drawing.Size(820, 181);
            this.m_CoverPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_CoverPhotoPictureBox.TabIndex = 20;
            this.m_CoverPhotoPictureBox.TabStop = false;
            // 
            // m_Collage
            // 
            this.m_Collage.Location = new System.Drawing.Point(322, 353);
            this.m_Collage.Margin = new System.Windows.Forms.Padding(2);
            this.m_Collage.Name = "m_Collage";
            this.m_Collage.Size = new System.Drawing.Size(129, 81);
            this.m_Collage.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.m_AlbumsButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_FriendsButton);
            this.Controls.Add(this.m_UserInfoButton);
            this.Controls.Add(this.findEventButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.newPostTextBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.m_CoverPhotoPictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_CoverPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox newPostTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private Collage m_Collage = new Collage();
        private System.Windows.Forms.Button findEventButton;
        private System.Windows.Forms.Button m_UserInfoButton;
        private System.Windows.Forms.Button m_FriendsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button m_AlbumsButton;
        private System.Windows.Forms.PictureBox m_CoverPhotoPictureBox;
    }
}
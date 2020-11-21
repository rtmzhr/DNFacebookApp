
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
            this.m_Collage = new DN_EX1.Collage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_FriendsButton = new System.Windows.Forms.Button();
            this.m_UserInfoButton = new System.Windows.Forms.Button();
            this.findEventButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newPostTextBox
            // 
            this.newPostTextBox.Location = new System.Drawing.Point(184, 128);
            this.newPostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPostTextBox.Multiline = true;
            this.newPostTextBox.Name = "newPostTextBox";
            this.newPostTextBox.Size = new System.Drawing.Size(294, 64);
            this.newPostTextBox.TabIndex = 2;
            this.newPostTextBox.Text = "What\'s on your mind?";
            // 
            // postsListBox
            // 
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(184, 243);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(367, 82);
            this.postsListBox.TabIndex = 8;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(125, 40);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(172, 25);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "##WELCOME##";
            // 
            // m_Collage
            // 
            this.m_Collage.Location = new System.Drawing.Point(322, 353);
            this.m_Collage.Margin = new System.Windows.Forms.Padding(2);
            this.m_Collage.Name = "m_Collage";
            this.m_Collage.Size = new System.Drawing.Size(129, 81);
            this.m_Collage.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_21_51_PM;
            this.button3.Location = new System.Drawing.Point(11, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 44);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_16_32_PM;
            this.button2.Location = new System.Drawing.Point(11, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // m_FriendsButton
            // 
            this.m_FriendsButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_14_PM;
            this.m_FriendsButton.Location = new System.Drawing.Point(11, 164);
            this.m_FriendsButton.Name = "m_FriendsButton";
            this.m_FriendsButton.Size = new System.Drawing.Size(108, 44);
            this.m_FriendsButton.TabIndex = 16;
            this.m_FriendsButton.UseVisualStyleBackColor = true;
            this.m_FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // m_UserInfoButton
            // 
            this.m_UserInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_UserInfoButton.BackgroundImage")));
            this.m_UserInfoButton.Location = new System.Drawing.Point(67, 56);
            this.m_UserInfoButton.Name = "m_UserInfoButton";
            this.m_UserInfoButton.Size = new System.Drawing.Size(39, 41);
            this.m_UserInfoButton.TabIndex = 15;
            this.m_UserInfoButton.UseVisualStyleBackColor = true;
            this.m_UserInfoButton.Click += new System.EventHandler(this.m_UserInfoButton_Click);
            // 
            // findEventButton
            // 
            this.findEventButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_11_42_PM;
            this.findEventButton.Location = new System.Drawing.Point(11, 125);
            this.findEventButton.Name = "findEventButton";
            this.findEventButton.Size = new System.Drawing.Size(108, 33);
            this.findEventButton.TabIndex = 14;
            this.findEventButton.UseVisualStyleBackColor = true;
            this.findEventButton.Click += new System.EventHandler(this.findEventButton_Click);
            // 
            // postButton
            // 
            this.postButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_01_PM;
            this.postButton.Location = new System.Drawing.Point(482, 164);
            this.postButton.Margin = new System.Windows.Forms.Padding(2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 28);
            this.postButton.TabIndex = 3;
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(11, 8);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(95, 89);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_13_55_PM;
            this.logoutButton.Location = new System.Drawing.Point(491, 8);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(55, 68);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 350);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_FriendsButton);
            this.Controls.Add(this.m_UserInfoButton);
            this.Controls.Add(this.findEventButton);
            this.Controls.Add(this.m_Collage);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.postsListBox);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.newPostTextBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.logoutButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private Collage m_Collage = new Collage();
        private System.Windows.Forms.Button findEventButton;
        private System.Windows.Forms.Button m_UserInfoButton;
        private System.Windows.Forms.Button m_FriendsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
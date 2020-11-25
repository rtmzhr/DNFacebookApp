namespace DN_EX1
{
    partial class GroupsForm
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
            this.m_SearchFriendButton = new System.Windows.Forms.Button();
            this.m_GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.m_ShowFrienInfo = new System.Windows.Forms.Button();
            this.m_GroupsListBox = new System.Windows.Forms.ListBox();
            this.m_LoggedInProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.m_FriendsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_SearchFriendButton
            // 
            this.m_SearchFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_SearchFriendButton.Location = new System.Drawing.Point(303, 172);
            this.m_SearchFriendButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_SearchFriendButton.Name = "m_SearchFriendButton";
            this.m_SearchFriendButton.Size = new System.Drawing.Size(136, 44);
            this.m_SearchFriendButton.TabIndex = 28;
            this.m_SearchFriendButton.Text = "Search";
            this.m_SearchFriendButton.UseVisualStyleBackColor = true;
            // 
            // m_GroupNameTextBox
            // 
            this.m_GroupNameTextBox.Location = new System.Drawing.Point(451, 172);
            this.m_GroupNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.m_GroupNameTextBox.Name = "m_GroupNameTextBox";
            this.m_GroupNameTextBox.Size = new System.Drawing.Size(370, 31);
            this.m_GroupNameTextBox.TabIndex = 27;
            // 
            // m_ShowFrienInfo
            // 
            this.m_ShowFrienInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ShowFrienInfo.Location = new System.Drawing.Point(861, 153);
            this.m_ShowFrienInfo.Margin = new System.Windows.Forms.Padding(6);
            this.m_ShowFrienInfo.Name = "m_ShowFrienInfo";
            this.m_ShowFrienInfo.Size = new System.Drawing.Size(174, 63);
            this.m_ShowFrienInfo.TabIndex = 26;
            this.m_ShowFrienInfo.Text = "Show Info";
            this.m_ShowFrienInfo.UseVisualStyleBackColor = true;
            this.m_ShowFrienInfo.Click += new System.EventHandler(this.showGroupInfo_Click);
            // 
            // m_GroupsListBox
            // 
            this.m_GroupsListBox.FormattingEnabled = true;
            this.m_GroupsListBox.ItemHeight = 25;
            this.m_GroupsListBox.Location = new System.Drawing.Point(303, 226);
            this.m_GroupsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_GroupsListBox.Name = "m_GroupsListBox";
            this.m_GroupsListBox.Size = new System.Drawing.Size(730, 179);
            this.m_GroupsListBox.TabIndex = 25;
            // 
            // m_LoggedInProfilePictureBox
            // 
            this.m_LoggedInProfilePictureBox.Location = new System.Drawing.Point(41, 42);
            this.m_LoggedInProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_LoggedInProfilePictureBox.Name = "m_LoggedInProfilePictureBox";
            this.m_LoggedInProfilePictureBox.Size = new System.Drawing.Size(226, 171);
            this.m_LoggedInProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_LoggedInProfilePictureBox.TabIndex = 24;
            this.m_LoggedInProfilePictureBox.TabStop = false;
            // 
            // m_FriendsButton
            // 
            this.m_FriendsButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_16_32_PM;
            this.m_FriendsButton.Location = new System.Drawing.Point(303, 42);
            this.m_FriendsButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_FriendsButton.Name = "m_FriendsButton";
            this.m_FriendsButton.Size = new System.Drawing.Size(216, 85);
            this.m_FriendsButton.TabIndex = 23;
            this.m_FriendsButton.UseVisualStyleBackColor = true;
            this.m_FriendsButton.Click += new System.EventHandler(this.fetchGroupsButton_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 478);
            this.Controls.Add(this.m_SearchFriendButton);
            this.Controls.Add(this.m_GroupNameTextBox);
            this.Controls.Add(this.m_ShowFrienInfo);
            this.Controls.Add(this.m_GroupsListBox);
            this.Controls.Add(this.m_LoggedInProfilePictureBox);
            this.Controls.Add(this.m_FriendsButton);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_SearchFriendButton;
        private System.Windows.Forms.TextBox m_GroupNameTextBox;
        private System.Windows.Forms.Button m_ShowFrienInfo;
        private System.Windows.Forms.ListBox m_GroupsListBox;
        private System.Windows.Forms.PictureBox m_LoggedInProfilePictureBox;
        private System.Windows.Forms.Button m_FriendsButton;
    }
}
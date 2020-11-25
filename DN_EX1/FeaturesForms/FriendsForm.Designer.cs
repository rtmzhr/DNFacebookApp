namespace DN_EX1
{
    partial class FriendsForm
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
            this.m_FriendsButton = new System.Windows.Forms.Button();
            this.m_LoggedInProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.m_FriendsListBox = new System.Windows.Forms.ListBox();
            this.m_ShowFrienInfo = new System.Windows.Forms.Button();
            this.m_FriendNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_FriendsButton
            // 
            this.m_FriendsButton.BackgroundImage = global::DN_EX1.Properties.Resources.Screen_Shot_2020_11_21_at_11_09_14_PM;
            this.m_FriendsButton.Location = new System.Drawing.Point(284, 35);
            this.m_FriendsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_FriendsButton.Name = "m_FriendsButton";
            this.m_FriendsButton.Size = new System.Drawing.Size(216, 85);
            this.m_FriendsButton.TabIndex = 17;
            this.m_FriendsButton.UseVisualStyleBackColor = true;
            this.m_FriendsButton.Click += new System.EventHandler(this.m_FriendsButton_Click);
            // 
            // m_LoggedInProfilePictureBox
            // 
            this.m_LoggedInProfilePictureBox.Location = new System.Drawing.Point(22, 35);
            this.m_LoggedInProfilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_LoggedInProfilePictureBox.Name = "m_LoggedInProfilePictureBox";
            this.m_LoggedInProfilePictureBox.Size = new System.Drawing.Size(226, 171);
            this.m_LoggedInProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_LoggedInProfilePictureBox.TabIndex = 18;
            this.m_LoggedInProfilePictureBox.TabStop = false;
            // 
            // m_FriendsListBox
            // 
            this.m_FriendsListBox.FormattingEnabled = true;
            this.m_FriendsListBox.ItemHeight = 25;
            this.m_FriendsListBox.Location = new System.Drawing.Point(284, 219);
            this.m_FriendsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_FriendsListBox.Name = "m_FriendsListBox";
            this.m_FriendsListBox.Size = new System.Drawing.Size(730, 179);
            this.m_FriendsListBox.TabIndex = 19;
            // 
            // m_ShowFrienInfo
            // 
            this.m_ShowFrienInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ShowFrienInfo.Location = new System.Drawing.Point(842, 146);
            this.m_ShowFrienInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_ShowFrienInfo.Name = "m_ShowFrienInfo";
            this.m_ShowFrienInfo.Size = new System.Drawing.Size(174, 63);
            this.m_ShowFrienInfo.TabIndex = 20;
            this.m_ShowFrienInfo.Text = "Show Info";
            this.m_ShowFrienInfo.UseVisualStyleBackColor = true;
            this.m_ShowFrienInfo.Click += new System.EventHandler(this.ShowFriendInfo_Click);
            // 
            // m_FriendNameTextBox
            // 
            this.m_FriendNameTextBox.Location = new System.Drawing.Point(432, 165);
            this.m_FriendNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.m_FriendNameTextBox.Name = "m_FriendNameTextBox";
            this.m_FriendNameTextBox.Size = new System.Drawing.Size(370, 31);
            this.m_FriendNameTextBox.TabIndex = 21;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 423);
            this.Controls.Add(this.m_FriendNameTextBox);
            this.Controls.Add(this.m_ShowFrienInfo);
            this.Controls.Add(this.m_FriendsListBox);
            this.Controls.Add(this.m_LoggedInProfilePictureBox);
            this.Controls.Add(this.m_FriendsButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_LoggedInProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_FriendsButton;
        private System.Windows.Forms.PictureBox m_LoggedInProfilePictureBox;
        private System.Windows.Forms.ListBox m_FriendsListBox;
        private System.Windows.Forms.Button m_ShowFrienInfo;
        private System.Windows.Forms.TextBox m_FriendNameTextBox;
    }
}
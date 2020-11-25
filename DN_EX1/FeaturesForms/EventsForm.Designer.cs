namespace DN_EX1
{
    partial class EventsForm
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
            this.explnationLabel = new System.Windows.Forms.Label();
            this.m_FromDateTime = new System.Windows.Forms.DateTimePicker();
            this.m_UntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.untilLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.m_UpToLabel = new System.Windows.Forms.Label();
            this.m_PeopleLimitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_FetchMyEventsButton = new System.Windows.Forms.Button();
            this.m_FetchFriendsEventsButton = new System.Windows.Forms.Button();
            this.m_PrivacyLabel = new System.Windows.Forms.Label();
            this.m_OpenCheckBox = new System.Windows.Forms.CheckBox();
            this.m_CloseCheckBox = new System.Windows.Forms.CheckBox();
            this.m_SecretCheckBox = new System.Windows.Forms.CheckBox();
            this.m_ShowFrienInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // explnationLabel
            // 
            this.explnationLabel.AutoSize = true;
            this.explnationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explnationLabel.Location = new System.Drawing.Point(44, 54);
            this.explnationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.explnationLabel.Name = "explnationLabel";
            this.explnationLabel.Size = new System.Drawing.Size(737, 46);
            this.explnationLabel.TabIndex = 0;
            this.explnationLabel.Text = "Let us help you find a cool event for you!";
            // 
            // m_FromDateTime
            // 
            this.m_FromDateTime.Location = new System.Drawing.Point(290, 163);
            this.m_FromDateTime.Margin = new System.Windows.Forms.Padding(6);
            this.m_FromDateTime.MinDate = new System.DateTime(2020, 11, 21, 20, 11, 23, 258);
            this.m_FromDateTime.Name = "m_FromDateTime";
            this.m_FromDateTime.Size = new System.Drawing.Size(396, 31);
            this.m_FromDateTime.TabIndex = 1;
            // 
            // m_UntilDateTime
            // 
            this.m_UntilDateTime.Location = new System.Drawing.Point(290, 262);
            this.m_UntilDateTime.Margin = new System.Windows.Forms.Padding(6);
            this.m_UntilDateTime.MinDate = new System.DateTime(2020, 11, 21, 20, 11, 23, 258);
            this.m_UntilDateTime.Name = "m_UntilDateTime";
            this.m_UntilDateTime.Size = new System.Drawing.Size(396, 31);
            this.m_UntilDateTime.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(102, 163);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(97, 37);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From";
            // 
            // untilLabel
            // 
            this.untilLabel.AutoSize = true;
            this.untilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untilLabel.Location = new System.Drawing.Point(102, 262);
            this.untilLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.untilLabel.Name = "untilLabel";
            this.untilLabel.Size = new System.Drawing.Size(86, 37);
            this.untilLabel.TabIndex = 4;
            this.untilLabel.Text = "Until";
            // 
            // findButton
            // 
            this.findButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findButton.Location = new System.Drawing.Point(700, 500);
            this.findButton.Margin = new System.Windows.Forms.Padding(6);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(150, 44);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "SEARCH";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.searchEventButton_Click);
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 25;
            this.eventsListBox.Location = new System.Drawing.Point(862, 113);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(622, 429);
            this.eventsListBox.TabIndex = 6;
            // 
            // m_UpToLabel
            // 
            this.m_UpToLabel.AutoSize = true;
            this.m_UpToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_UpToLabel.Location = new System.Drawing.Point(102, 500);
            this.m_UpToLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_UpToLabel.Name = "m_UpToLabel";
            this.m_UpToLabel.Size = new System.Drawing.Size(109, 37);
            this.m_UpToLabel.TabIndex = 13;
            this.m_UpToLabel.Text = "Up to ";
            // 
            // m_PeopleLimitTextBox
            // 
            this.m_PeopleLimitTextBox.Location = new System.Drawing.Point(272, 500);
            this.m_PeopleLimitTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.m_PeopleLimitTextBox.Name = "m_PeopleLimitTextBox";
            this.m_PeopleLimitTextBox.Size = new System.Drawing.Size(196, 31);
            this.m_PeopleLimitTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "People";
            // 
            // m_FetchMyEventsButton
            // 
            this.m_FetchMyEventsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_FetchMyEventsButton.Location = new System.Drawing.Point(920, 23);
            this.m_FetchMyEventsButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_FetchMyEventsButton.Name = "m_FetchMyEventsButton";
            this.m_FetchMyEventsButton.Size = new System.Drawing.Size(208, 75);
            this.m_FetchMyEventsButton.TabIndex = 16;
            this.m_FetchMyEventsButton.Text = "Fetch My Events";
            this.m_FetchMyEventsButton.UseVisualStyleBackColor = true;
            this.m_FetchMyEventsButton.Click += new System.EventHandler(this.fetchMyEvents_Click);
            // 
            // m_FetchFriendsEventsButton
            // 
            this.m_FetchFriendsEventsButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_FetchFriendsEventsButton.Location = new System.Drawing.Point(1256, 23);
            this.m_FetchFriendsEventsButton.Margin = new System.Windows.Forms.Padding(6);
            this.m_FetchFriendsEventsButton.Name = "m_FetchFriendsEventsButton";
            this.m_FetchFriendsEventsButton.Size = new System.Drawing.Size(198, 75);
            this.m_FetchFriendsEventsButton.TabIndex = 17;
            this.m_FetchFriendsEventsButton.Text = "Fetch my friend\'s events";
            this.m_FetchFriendsEventsButton.UseVisualStyleBackColor = true;
            this.m_FetchFriendsEventsButton.Click += new System.EventHandler(this.fetchFriendsEvents_Click);
            // 
            // m_PrivacyLabel
            // 
            this.m_PrivacyLabel.AutoSize = true;
            this.m_PrivacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PrivacyLabel.Location = new System.Drawing.Point(102, 372);
            this.m_PrivacyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.m_PrivacyLabel.Name = "m_PrivacyLabel";
            this.m_PrivacyLabel.Size = new System.Drawing.Size(127, 37);
            this.m_PrivacyLabel.TabIndex = 18;
            this.m_PrivacyLabel.Text = "Privacy";
            // 
            // m_OpenCheckBox
            // 
            this.m_OpenCheckBox.AutoSize = true;
            this.m_OpenCheckBox.Location = new System.Drawing.Point(290, 372);
            this.m_OpenCheckBox.Name = "m_OpenCheckBox";
            this.m_OpenCheckBox.Size = new System.Drawing.Size(96, 29);
            this.m_OpenCheckBox.TabIndex = 22;
            this.m_OpenCheckBox.Text = "Open";
            this.m_OpenCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_CloseCheckBox
            // 
            this.m_CloseCheckBox.AutoSize = true;
            this.m_CloseCheckBox.Location = new System.Drawing.Point(434, 372);
            this.m_CloseCheckBox.Name = "m_CloseCheckBox";
            this.m_CloseCheckBox.Size = new System.Drawing.Size(99, 29);
            this.m_CloseCheckBox.TabIndex = 23;
            this.m_CloseCheckBox.Text = "Close";
            this.m_CloseCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_SecretCheckBox
            // 
            this.m_SecretCheckBox.AutoSize = true;
            this.m_SecretCheckBox.Location = new System.Drawing.Point(580, 372);
            this.m_SecretCheckBox.Name = "m_SecretCheckBox";
            this.m_SecretCheckBox.Size = new System.Drawing.Size(106, 29);
            this.m_SecretCheckBox.TabIndex = 24;
            this.m_SecretCheckBox.Text = "Secret";
            this.m_SecretCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_ShowFrienInfo
            // 
            this.m_ShowFrienInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ShowFrienInfo.Location = new System.Drawing.Point(1310, 545);
            this.m_ShowFrienInfo.Margin = new System.Windows.Forms.Padding(6);
            this.m_ShowFrienInfo.Name = "m_ShowFrienInfo";
            this.m_ShowFrienInfo.Size = new System.Drawing.Size(174, 63);
            this.m_ShowFrienInfo.TabIndex = 25;
            this.m_ShowFrienInfo.Text = "Show Info";
            this.m_ShowFrienInfo.UseVisualStyleBackColor = true;
            this.m_ShowFrienInfo.Click += new System.EventHandler(this.showFrienInfo_Click);
            // 
            // FindEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 640);
            this.Controls.Add(this.m_ShowFrienInfo);
            this.Controls.Add(this.m_SecretCheckBox);
            this.Controls.Add(this.m_CloseCheckBox);
            this.Controls.Add(this.m_OpenCheckBox);
            this.Controls.Add(this.m_PrivacyLabel);
            this.Controls.Add(this.m_FetchFriendsEventsButton);
            this.Controls.Add(this.m_FetchMyEventsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_PeopleLimitTextBox);
            this.Controls.Add(this.m_UpToLabel);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.untilLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.m_UntilDateTime);
            this.Controls.Add(this.m_FromDateTime);
            this.Controls.Add(this.explnationLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FindEventsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explnationLabel;
        private System.Windows.Forms.DateTimePicker m_FromDateTime;
        private System.Windows.Forms.DateTimePicker m_UntilDateTime;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label untilLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Label m_UpToLabel;
        private System.Windows.Forms.TextBox m_PeopleLimitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_FetchMyEventsButton;
        private System.Windows.Forms.Button m_FetchFriendsEventsButton;
        private System.Windows.Forms.Label m_PrivacyLabel;
        private System.Windows.Forms.CheckBox m_OpenCheckBox;
        private System.Windows.Forms.CheckBox m_CloseCheckBox;
        private System.Windows.Forms.CheckBox m_SecretCheckBox;
        private System.Windows.Forms.Button m_ShowFrienInfo;
    }
}
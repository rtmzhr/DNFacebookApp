namespace DN_EX1
{
    partial class FindEventsForm
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
            this.m_PrivacyRadioButtons = new PrivacyRadioButtons(this);
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_PrivacyRadioButtons
            // 
            this.m_PrivacyRadioButtons.Location = new System.Drawing.Point(56, 201);
            this.m_PrivacyRadioButtons.Name = "m_PrivacyRadioButtons";
            this.m_PrivacyRadioButtons.Size = new System.Drawing.Size(0, 0);
            this.m_PrivacyRadioButtons.TabIndex = 12;
            // 
            // explnationLabel
            // 
            this.explnationLabel.AutoSize = true;
            this.explnationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explnationLabel.Location = new System.Drawing.Point(22, 28);
            this.explnationLabel.Name = "explnationLabel";
            this.explnationLabel.Size = new System.Drawing.Size(360, 25);
            this.explnationLabel.TabIndex = 0;
            this.explnationLabel.Text = "Let us help you find a cool event for you!";
            // 
            // m_FromDateTime
            // 
            this.m_FromDateTime.Location = new System.Drawing.Point(145, 85);
            this.m_FromDateTime.MinDate = new System.DateTime(2020, 11, 21, 20, 11, 23, 258);
            this.m_FromDateTime.Name = "m_FromDateTime";
            this.m_FromDateTime.Size = new System.Drawing.Size(200, 20);
            this.m_FromDateTime.TabIndex = 1;
            // 
            // m_UntilDateTime
            // 
            this.m_UntilDateTime.Location = new System.Drawing.Point(145, 136);
            this.m_UntilDateTime.MinDate = new System.DateTime(2020, 11, 21, 20, 11, 23, 258);
            this.m_UntilDateTime.Name = "m_UntilDateTime";
            this.m_UntilDateTime.Size = new System.Drawing.Size(200, 20);
            this.m_UntilDateTime.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(51, 85);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(50, 20);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From";
            // 
            // untilLabel
            // 
            this.untilLabel.AutoSize = true;
            this.untilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untilLabel.Location = new System.Drawing.Point(51, 136);
            this.untilLabel.Name = "untilLabel";
            this.untilLabel.Size = new System.Drawing.Size(46, 20);
            this.untilLabel.TabIndex = 4;
            this.untilLabel.Text = "Until";
            // 
            // findButton
            // 
            this.findButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.findButton.Location = new System.Drawing.Point(350, 260);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "SEARCH";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // eventsListBox
            // 
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(431, 59);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(313, 225);
            this.eventsListBox.TabIndex = 6;
            // 
            // m_UpToLabel
            // 
            this.m_UpToLabel.AutoSize = true;
            this.m_UpToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_UpToLabel.Location = new System.Drawing.Point(52, 260);
            this.m_UpToLabel.Name = "m_UpToLabel";
            this.m_UpToLabel.Size = new System.Drawing.Size(58, 20);
            this.m_UpToLabel.TabIndex = 13;
            this.m_UpToLabel.Text = "Up to ";
            // 
            // m_PeopleLimitTextBox
            // 
            this.m_PeopleLimitTextBox.Location = new System.Drawing.Point(136, 260);
            this.m_PeopleLimitTextBox.Name = "m_PeopleLimitTextBox";
            this.m_PeopleLimitTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_PeopleLimitTextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "People";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fetch My Events";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(628, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Fetch my friend\'s events";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FindEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 333);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Name = "FindEventsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explnationLabel;
        private PrivacyRadioButtons m_PrivacyRadioButtons;
        private System.Windows.Forms.DateTimePicker m_FromDateTime;
        private System.Windows.Forms.DateTimePicker m_UntilDateTime;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label untilLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.Label m_UpToLabel;
        private System.Windows.Forms.TextBox m_PeopleLimitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
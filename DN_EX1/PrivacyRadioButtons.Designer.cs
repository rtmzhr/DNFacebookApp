using System;
using System.Windows.Forms;

namespace DN_EX1
{
    partial class PrivacyRadioButtons : Control
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
            //
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
            this.m_DontCareRadioButton.Location = new System.Drawing.Point(Location.X +
                (int)((m_PrivacyLabel.Width + m_OpenRadioButton.Width + m_SecretRadioButton.Width +
                m_ClosedRadioButton.Width) * 1.3), Location.Y);
            this.m_SecretRadioButton.Location = new System.Drawing.Point(Location.X +
                (int)((m_PrivacyLabel.Width + m_OpenRadioButton.Width + m_SecretRadioButton.Width) * 1.3)
                , Location.Y);
            this.m_ClosedRadioButton.Location = new System.Drawing.Point( Location.X +
                (int)((m_PrivacyLabel.Width + m_OpenRadioButton.Width) * 1.3), Location.Y);
            this.m_OpenRadioButton.Location = new System.Drawing.Point(Location.X + (int)(m_PrivacyLabel.Width * 1.3)
                , Location.Y);
            this.m_PrivacyLabel.Location = Location;
        }
       
        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_DontCareRadioButton = new System.Windows.Forms.RadioButton();
            this.m_SecretRadioButton = new System.Windows.Forms.RadioButton();
            this.m_ClosedRadioButton = new System.Windows.Forms.RadioButton();
            this.m_OpenRadioButton = new System.Windows.Forms.RadioButton();
            this.m_PrivacyLabel = new System.Windows.Forms.Label();
            // 
            // m_DontCareRadioButton
            // 
            this.m_DontCareRadioButton.AutoSize = true;
            this.m_DontCareRadioButton.Name = "m_DontCareRadioButton";
            this.m_DontCareRadioButton.Size = new System.Drawing.Size(56, 17);
            this.m_DontCareRadioButton.TabIndex = 11;
            this.m_DontCareRadioButton.TabStop = true;
            this.m_DontCareRadioButton.Text = "Don't Care";
            this.m_DontCareRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_SecretRadioButton
            // 
            this.m_SecretRadioButton.AutoSize = true;
            this.m_SecretRadioButton.Name = "m_SecretRadioButton";
            this.m_SecretRadioButton.Size = new System.Drawing.Size(56, 17);
            this.m_SecretRadioButton.TabIndex = 11;
            this.m_SecretRadioButton.TabStop = true;
            this.m_SecretRadioButton.Text = "Secret";
            this.m_SecretRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_ClosedRadioButton
            // 
            this.m_ClosedRadioButton.AutoSize = true;
            this.m_ClosedRadioButton.Name = "m_ClosedRadioButton";
            this.m_ClosedRadioButton.Size = new System.Drawing.Size(57, 17);
            this.m_ClosedRadioButton.TabIndex = 10;
            this.m_ClosedRadioButton.TabStop = true;
            this.m_ClosedRadioButton.Text = "Closed";
            this.m_ClosedRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_OpenRadioButton
            // 
            this.m_OpenRadioButton.AutoSize = true;
            this.m_OpenRadioButton.Name = "m_OpenRadioButton";
            this.m_OpenRadioButton.Size = new System.Drawing.Size(51, 17);
            this.m_OpenRadioButton.TabIndex = 9;
            this.m_OpenRadioButton.TabStop = true;
            this.m_OpenRadioButton.Text = "Open";
            this.m_OpenRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_PrivacyLabel
            // 
            this.m_PrivacyLabel.AutoSize = true;
            this.m_PrivacyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PrivacyLabel.Name = "m_PrivacyLabel";
            this.m_PrivacyLabel.Size = new System.Drawing.Size(65, 20);
            this.m_PrivacyLabel.TabIndex = 8;
            this.m_PrivacyLabel.Text = "Privacy";
            OnLocationChanged(EventArgs.Empty);

            m_Form.Controls.Add(this.m_SecretRadioButton);
            m_Form.Controls.Add(this.m_OpenRadioButton);
            m_Form.Controls.Add(this.m_ClosedRadioButton);
            m_Form.Controls.Add(this.m_PrivacyLabel);
            m_Form.Controls.Add(this.m_DontCareRadioButton);

        }

        #endregion

        private System.Windows.Forms.RadioButton m_SecretRadioButton;
        private System.Windows.Forms.RadioButton m_DontCareRadioButton;
        private System.Windows.Forms.RadioButton m_ClosedRadioButton;
        private System.Windows.Forms.RadioButton m_OpenRadioButton;
        private System.Windows.Forms.Label m_PrivacyLabel;
    }
}

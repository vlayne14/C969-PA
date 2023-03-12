namespace Victoria_Brown_C969_PA
{
    partial class Appointment_Types
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
			this.appointmentTypesLabel = new System.Windows.Forms.Label();
			this.apptTypeCloseButton = new System.Windows.Forms.Button();
			this.apptTypeText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// appointmentTypesLabel
			// 
			this.appointmentTypesLabel.AutoSize = true;
			this.appointmentTypesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentTypesLabel.Location = new System.Drawing.Point(225, 9);
			this.appointmentTypesLabel.Name = "appointmentTypesLabel";
			this.appointmentTypesLabel.Size = new System.Drawing.Size(163, 20);
			this.appointmentTypesLabel.TabIndex = 71;
			this.appointmentTypesLabel.Text = "Appointment Types";
			// 
			// apptTypeCloseButton
			// 
			this.apptTypeCloseButton.Location = new System.Drawing.Point(508, 211);
			this.apptTypeCloseButton.Name = "apptTypeCloseButton";
			this.apptTypeCloseButton.Size = new System.Drawing.Size(99, 26);
			this.apptTypeCloseButton.TabIndex = 91;
			this.apptTypeCloseButton.Text = "Close";
			this.apptTypeCloseButton.UseVisualStyleBackColor = true;
			this.apptTypeCloseButton.Click += new System.EventHandler(this.apptTypeCloseButton_Click);
			// 
			// apptTypeText
			// 
			this.apptTypeText.Location = new System.Drawing.Point(29, 47);
			this.apptTypeText.Multiline = true;
			this.apptTypeText.Name = "apptTypeText";
			this.apptTypeText.Size = new System.Drawing.Size(565, 139);
			this.apptTypeText.TabIndex = 92;
			// 
			// Appointment_Types
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 248);
			this.Controls.Add(this.apptTypeText);
			this.Controls.Add(this.apptTypeCloseButton);
			this.Controls.Add(this.appointmentTypesLabel);
			this.Name = "Appointment_Types";
			this.Text = "Appointment_Types";
			this.Load += new System.EventHandler(this.Appointment_Types_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label appointmentTypesLabel;
        private System.Windows.Forms.Button apptTypeCloseButton;
		private System.Windows.Forms.TextBox apptTypeText;
	}
}
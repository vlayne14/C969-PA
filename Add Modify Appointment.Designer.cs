namespace Victoria_Brown_C969_PA
{
    partial class Add_Modify_Appointment
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
			this.addApptLabel = new System.Windows.Forms.Label();
			this.apptIDLabel = new System.Windows.Forms.Label();
			this.customerIDLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.titleText = new System.Windows.Forms.TextBox();
			this.typeLabel = new System.Windows.Forms.Label();
			this.startTimeLabel = new System.Windows.Forms.Label();
			this.endTimeLabel = new System.Windows.Forms.Label();
			this.addApptSaveButton = new System.Windows.Forms.Button();
			this.addApptCloseButton = new System.Windows.Forms.Button();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.endDatePicker = new System.Windows.Forms.DateTimePicker();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.customerIDComboBox = new System.Windows.Forms.ComboBox();
			this.addApptIDLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addApptLabel
			// 
			this.addApptLabel.AutoSize = true;
			this.addApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addApptLabel.Location = new System.Drawing.Point(116, 9);
			this.addApptLabel.Name = "addApptLabel";
			this.addApptLabel.Size = new System.Drawing.Size(148, 20);
			this.addApptLabel.TabIndex = 0;
			this.addApptLabel.Text = "Add Appointment";
			// 
			// apptIDLabel
			// 
			this.apptIDLabel.AutoSize = true;
			this.apptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apptIDLabel.Location = new System.Drawing.Point(12, 65);
			this.apptIDLabel.Name = "apptIDLabel";
			this.apptIDLabel.Size = new System.Drawing.Size(99, 16);
			this.apptIDLabel.TabIndex = 1;
			this.apptIDLabel.Text = "Appointment ID";
			// 
			// customerIDLabel
			// 
			this.customerIDLabel.AutoSize = true;
			this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerIDLabel.Location = new System.Drawing.Point(12, 104);
			this.customerIDLabel.Name = "customerIDLabel";
			this.customerIDLabel.Size = new System.Drawing.Size(68, 16);
			this.customerIDLabel.TabIndex = 5;
			this.customerIDLabel.Text = "Customer ";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(12, 138);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(34, 16);
			this.titleLabel.TabIndex = 7;
			this.titleLabel.Text = "Title";
			// 
			// titleText
			// 
			this.titleText.Location = new System.Drawing.Point(138, 134);
			this.titleText.Name = "titleText";
			this.titleText.Size = new System.Drawing.Size(194, 20);
			this.titleText.TabIndex = 8;
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.typeLabel.Location = new System.Drawing.Point(12, 172);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(40, 16);
			this.typeLabel.TabIndex = 15;
			this.typeLabel.Text = "Type";
			// 
			// startTimeLabel
			// 
			this.startTimeLabel.AutoSize = true;
			this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startTimeLabel.Location = new System.Drawing.Point(12, 208);
			this.startTimeLabel.Name = "startTimeLabel";
			this.startTimeLabel.Size = new System.Drawing.Size(69, 16);
			this.startTimeLabel.TabIndex = 23;
			this.startTimeLabel.Text = "Start Time";
			// 
			// endTimeLabel
			// 
			this.endTimeLabel.AutoSize = true;
			this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.endTimeLabel.Location = new System.Drawing.Point(12, 243);
			this.endTimeLabel.Name = "endTimeLabel";
			this.endTimeLabel.Size = new System.Drawing.Size(66, 16);
			this.endTimeLabel.TabIndex = 28;
			this.endTimeLabel.Text = "End Time";
			// 
			// addApptSaveButton
			// 
			this.addApptSaveButton.Location = new System.Drawing.Point(138, 283);
			this.addApptSaveButton.Name = "addApptSaveButton";
			this.addApptSaveButton.Size = new System.Drawing.Size(99, 26);
			this.addApptSaveButton.TabIndex = 32;
			this.addApptSaveButton.Text = "Save";
			this.addApptSaveButton.UseVisualStyleBackColor = true;
			this.addApptSaveButton.Click += new System.EventHandler(this.addApptSaveButton_Click);
			// 
			// addApptCloseButton
			// 
			this.addApptCloseButton.Location = new System.Drawing.Point(243, 283);
			this.addApptCloseButton.Name = "addApptCloseButton";
			this.addApptCloseButton.Size = new System.Drawing.Size(89, 26);
			this.addApptCloseButton.TabIndex = 33;
			this.addApptCloseButton.Text = "Close";
			this.addApptCloseButton.UseVisualStyleBackColor = true;
			this.addApptCloseButton.Click += new System.EventHandler(this.addApptCloseButton_Click);
			// 
			// startDatePicker
			// 
			this.startDatePicker.AllowDrop = true;
			this.startDatePicker.CustomFormat = "d-MMM-yyy hh:mm:ss";
			this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startDatePicker.Location = new System.Drawing.Point(138, 204);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.ShowUpDown = true;
			this.startDatePicker.Size = new System.Drawing.Size(194, 20);
			this.startDatePicker.TabIndex = 35;
			this.startDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startDatePicker_KeyPress);
			// 
			// endDatePicker
			// 
			this.endDatePicker.CustomFormat = "d-MMM-yyy hh:mm:ss";
			this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endDatePicker.Location = new System.Drawing.Point(138, 239);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.ShowUpDown = true;
			this.endDatePicker.Size = new System.Drawing.Size(194, 20);
			this.endDatePicker.TabIndex = 36;
			this.endDatePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endDatePicker_KeyPress);
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(138, 167);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(194, 21);
			this.typeComboBox.TabIndex = 37;
			// 
			// customerIDComboBox
			// 
			this.customerIDComboBox.FormattingEnabled = true;
			this.customerIDComboBox.Location = new System.Drawing.Point(138, 99);
			this.customerIDComboBox.Name = "customerIDComboBox";
			this.customerIDComboBox.Size = new System.Drawing.Size(194, 21);
			this.customerIDComboBox.TabIndex = 38;
			// 
			// addApptIDLabel
			// 
			this.addApptIDLabel.AutoSize = true;
			this.addApptIDLabel.Location = new System.Drawing.Point(135, 68);
			this.addApptIDLabel.Name = "addApptIDLabel";
			this.addApptIDLabel.Size = new System.Drawing.Size(0, 13);
			this.addApptIDLabel.TabIndex = 39;
			// 
			// Add_Modify_Appointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 326);
			this.Controls.Add(this.addApptIDLabel);
			this.Controls.Add(this.customerIDComboBox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.endDatePicker);
			this.Controls.Add(this.startDatePicker);
			this.Controls.Add(this.addApptCloseButton);
			this.Controls.Add(this.addApptSaveButton);
			this.Controls.Add(this.endTimeLabel);
			this.Controls.Add(this.startTimeLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.titleText);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.customerIDLabel);
			this.Controls.Add(this.apptIDLabel);
			this.Controls.Add(this.addApptLabel);
			this.Name = "Add_Modify_Appointment";
			this.Text = "Add_Appointment";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Modify_Appointment_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label apptIDLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Button addApptSaveButton;
        private System.Windows.Forms.Button addApptCloseButton;
		public System.Windows.Forms.TextBox titleText;
		public System.Windows.Forms.DateTimePicker startDatePicker;
		public System.Windows.Forms.DateTimePicker endDatePicker;
		public System.Windows.Forms.ComboBox typeComboBox;
		public System.Windows.Forms.ComboBox customerIDComboBox;
		public System.Windows.Forms.Label addApptLabel;
		public System.Windows.Forms.Label addApptIDLabel;
	}
}
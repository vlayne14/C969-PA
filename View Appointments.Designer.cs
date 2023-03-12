namespace Victoria_Brown_C969_PA
{
    partial class View_Appointments
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.allRadioButton = new System.Windows.Forms.RadioButton();
			this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
			this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
			this.viewApptDGV = new System.Windows.Forms.DataGridView();
			this.calendarViewLabel = new System.Windows.Forms.Label();
			this.viewApptCloseButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewApptDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.allRadioButton);
			this.panel1.Controls.Add(this.monthlyRadioButton);
			this.panel1.Controls.Add(this.weeklyRadioButton);
			this.panel1.Controls.Add(this.viewApptDGV);
			this.panel1.Location = new System.Drawing.Point(31, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 225);
			this.panel1.TabIndex = 0;
			// 
			// allRadioButton
			// 
			this.allRadioButton.AutoSize = true;
			this.allRadioButton.Location = new System.Drawing.Point(650, 192);
			this.allRadioButton.Name = "allRadioButton";
			this.allRadioButton.Size = new System.Drawing.Size(103, 17);
			this.allRadioButton.TabIndex = 3;
			this.allRadioButton.TabStop = true;
			this.allRadioButton.Text = "All Appointments";
			this.allRadioButton.UseVisualStyleBackColor = true;
			this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
			// 
			// monthlyRadioButton
			// 
			this.monthlyRadioButton.AutoSize = true;
			this.monthlyRadioButton.Location = new System.Drawing.Point(502, 192);
			this.monthlyRadioButton.Name = "monthlyRadioButton";
			this.monthlyRadioButton.Size = new System.Drawing.Size(129, 17);
			this.monthlyRadioButton.TabIndex = 2;
			this.monthlyRadioButton.TabStop = true;
			this.monthlyRadioButton.Text = "Monthly Appointments";
			this.monthlyRadioButton.UseVisualStyleBackColor = true;
			this.monthlyRadioButton.CheckedChanged += new System.EventHandler(this.monthlyRadioButton_CheckedChanged);
			// 
			// weeklyRadioButton
			// 
			this.weeklyRadioButton.AutoSize = true;
			this.weeklyRadioButton.Location = new System.Drawing.Point(347, 192);
			this.weeklyRadioButton.Name = "weeklyRadioButton";
			this.weeklyRadioButton.Size = new System.Drawing.Size(128, 17);
			this.weeklyRadioButton.TabIndex = 1;
			this.weeklyRadioButton.TabStop = true;
			this.weeklyRadioButton.Text = "Weekly Appointments";
			this.weeklyRadioButton.UseVisualStyleBackColor = true;
			this.weeklyRadioButton.CheckedChanged += new System.EventHandler(this.weeklyRadioButton_CheckedChanged);
			// 
			// viewApptDGV
			// 
			this.viewApptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewApptDGV.Location = new System.Drawing.Point(20, 17);
			this.viewApptDGV.Name = "viewApptDGV";
			this.viewApptDGV.Size = new System.Drawing.Size(744, 169);
			this.viewApptDGV.TabIndex = 0;
			// 
			// calendarViewLabel
			// 
			this.calendarViewLabel.AutoSize = true;
			this.calendarViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendarViewLabel.Location = new System.Drawing.Point(346, 9);
			this.calendarViewLabel.Name = "calendarViewLabel";
			this.calendarViewLabel.Size = new System.Drawing.Size(124, 20);
			this.calendarViewLabel.TabIndex = 70;
			this.calendarViewLabel.Text = "Calendar View";
			// 
			// viewApptCloseButton
			// 
			this.viewApptCloseButton.Location = new System.Drawing.Point(716, 285);
			this.viewApptCloseButton.Name = "viewApptCloseButton";
			this.viewApptCloseButton.Size = new System.Drawing.Size(99, 26);
			this.viewApptCloseButton.TabIndex = 90;
			this.viewApptCloseButton.Text = "Close";
			this.viewApptCloseButton.UseVisualStyleBackColor = true;
			this.viewApptCloseButton.Click += new System.EventHandler(this.viewApptCloseButton_Click);
			// 
			// View_Appointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 321);
			this.Controls.Add(this.viewApptCloseButton);
			this.Controls.Add(this.calendarViewLabel);
			this.Controls.Add(this.panel1);
			this.Name = "View_Appointments";
			this.Text = "View_Appointments";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewApptDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView viewApptDGV;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton weeklyRadioButton;
        private System.Windows.Forms.Label calendarViewLabel;
        private System.Windows.Forms.Button viewApptCloseButton;
    }
}
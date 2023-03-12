namespace Victoria_Brown_C969_PA
{
    partial class Consultant_Schedule
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
			this.consultantScheduleCloseButton = new System.Windows.Forms.Button();
			this.consultantScheduleLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.consultantScheduleComboBox = new System.Windows.Forms.ComboBox();
			this.consultantScheduleDGV = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.consultantScheduleDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// consultantScheduleCloseButton
			// 
			this.consultantScheduleCloseButton.Location = new System.Drawing.Point(721, 285);
			this.consultantScheduleCloseButton.Name = "consultantScheduleCloseButton";
			this.consultantScheduleCloseButton.Size = new System.Drawing.Size(99, 26);
			this.consultantScheduleCloseButton.TabIndex = 93;
			this.consultantScheduleCloseButton.Text = "Close";
			this.consultantScheduleCloseButton.UseVisualStyleBackColor = true;
			this.consultantScheduleCloseButton.Click += new System.EventHandler(this.consultantScheduleCloseButton_Click);
			// 
			// consultantScheduleLabel
			// 
			this.consultantScheduleLabel.AutoSize = true;
			this.consultantScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consultantScheduleLabel.Location = new System.Drawing.Point(351, 9);
			this.consultantScheduleLabel.Name = "consultantScheduleLabel";
			this.consultantScheduleLabel.Size = new System.Drawing.Size(176, 20);
			this.consultantScheduleLabel.TabIndex = 92;
			this.consultantScheduleLabel.Text = "Consultant Schedule";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.consultantScheduleComboBox);
			this.panel1.Controls.Add(this.consultantScheduleDGV);
			this.panel1.Location = new System.Drawing.Point(36, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 225);
			this.panel1.TabIndex = 91;
			// 
			// consultantScheduleComboBox
			// 
			this.consultantScheduleComboBox.FormattingEnabled = true;
			this.consultantScheduleComboBox.Location = new System.Drawing.Point(15, 15);
			this.consultantScheduleComboBox.Name = "consultantScheduleComboBox";
			this.consultantScheduleComboBox.Size = new System.Drawing.Size(213, 21);
			this.consultantScheduleComboBox.TabIndex = 94;
			this.consultantScheduleComboBox.Text = "Consultant Name";
			this.consultantScheduleComboBox.SelectedIndexChanged += new System.EventHandler(this.consultantScheduleComboBox_SelectedIndexChanged);
			// 
			// consultantScheduleDGV
			// 
			this.consultantScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.consultantScheduleDGV.Location = new System.Drawing.Point(15, 42);
			this.consultantScheduleDGV.Name = "consultantScheduleDGV";
			this.consultantScheduleDGV.Size = new System.Drawing.Size(744, 169);
			this.consultantScheduleDGV.TabIndex = 0;
			// 
			// Consultant_Schedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(856, 321);
			this.Controls.Add(this.consultantScheduleCloseButton);
			this.Controls.Add(this.consultantScheduleLabel);
			this.Controls.Add(this.panel1);
			this.Name = "Consultant_Schedule";
			this.Text = "Consultant_Schedule";
			this.Load += new System.EventHandler(this.Consultant_Schedule_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.consultantScheduleDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consultantScheduleCloseButton;
        private System.Windows.Forms.Label consultantScheduleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView consultantScheduleDGV;
        private System.Windows.Forms.ComboBox consultantScheduleComboBox;
    }
}
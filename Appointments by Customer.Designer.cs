namespace Victoria_Brown_C969_PA
{
    partial class Appointments_by_Customer
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
			this.apptByCustomerCloseButton = new System.Windows.Forms.Button();
			this.appointmentCustomerLabel = new System.Windows.Forms.Label();
			this.apptByCustDGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.apptByCustDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// apptByCustomerCloseButton
			// 
			this.apptByCustomerCloseButton.Location = new System.Drawing.Point(396, 321);
			this.apptByCustomerCloseButton.Name = "apptByCustomerCloseButton";
			this.apptByCustomerCloseButton.Size = new System.Drawing.Size(99, 26);
			this.apptByCustomerCloseButton.TabIndex = 95;
			this.apptByCustomerCloseButton.Text = "Close";
			this.apptByCustomerCloseButton.UseVisualStyleBackColor = true;
			this.apptByCustomerCloseButton.Click += new System.EventHandler(this.apptByCustomerCloseButton_Click);
			// 
			// appointmentCustomerLabel
			// 
			this.appointmentCustomerLabel.AutoSize = true;
			this.appointmentCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.appointmentCustomerLabel.Location = new System.Drawing.Point(134, 20);
			this.appointmentCustomerLabel.Name = "appointmentCustomerLabel";
			this.appointmentCustomerLabel.Size = new System.Drawing.Size(225, 20);
			this.appointmentCustomerLabel.TabIndex = 93;
			this.appointmentCustomerLabel.Text = "Appointments by Customer";
			// 
			// apptByCustDGV
			// 
			this.apptByCustDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.apptByCustDGV.Location = new System.Drawing.Point(21, 55);
			this.apptByCustDGV.Name = "apptByCustDGV";
			this.apptByCustDGV.Size = new System.Drawing.Size(474, 260);
			this.apptByCustDGV.TabIndex = 96;
			this.apptByCustDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.apptByCustDGV_DataBindingComplete);
			// 
			// Appointments_by_Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 361);
			this.Controls.Add(this.apptByCustDGV);
			this.Controls.Add(this.apptByCustomerCloseButton);
			this.Controls.Add(this.appointmentCustomerLabel);
			this.Name = "Appointments_by_Customer";
			this.Text = "Appointments_by_Customer";
			this.Load += new System.EventHandler(this.Appointments_by_Customer_Load);
			((System.ComponentModel.ISupportInitialize)(this.apptByCustDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button apptByCustomerCloseButton;
        private System.Windows.Forms.Label appointmentCustomerLabel;
		private System.Windows.Forms.DataGridView apptByCustDGV;
	}
}
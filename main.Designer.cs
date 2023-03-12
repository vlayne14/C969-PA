namespace Victoria_Brown_C969_PA
{
    partial class Main
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
			this.label1 = new System.Windows.Forms.Label();
			this.mainApptLabel = new System.Windows.Forms.Label();
			this.apptPanel = new System.Windows.Forms.Panel();
			this.mainApptDeleteButton = new System.Windows.Forms.Button();
			this.mainApptModifyButton = new System.Windows.Forms.Button();
			this.mainApptAddButton = new System.Windows.Forms.Button();
			this.mainApptDGV = new System.Windows.Forms.DataGridView();
			this.controlPanel = new System.Windows.Forms.Panel();
			this.apptCustomerButton = new System.Windows.Forms.Button();
			this.apptTypesButton = new System.Windows.Forms.Button();
			this.consultantScheButton = new System.Windows.Forms.Button();
			this.viewApptButton = new System.Windows.Forms.Button();
			this.controlsLabel = new System.Windows.Forms.Label();
			this.mainLogOffButton = new System.Windows.Forms.Button();
			this.customersButton = new System.Windows.Forms.Button();
			this.apptPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainApptDGV)).BeginInit();
			this.controlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(294, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Scheduling Software";
			// 
			// mainApptLabel
			// 
			this.mainApptLabel.AutoSize = true;
			this.mainApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainApptLabel.Location = new System.Drawing.Point(262, 9);
			this.mainApptLabel.Name = "mainApptLabel";
			this.mainApptLabel.Size = new System.Drawing.Size(108, 20);
			this.mainApptLabel.TabIndex = 1;
			this.mainApptLabel.Text = "Appointments";
			// 
			// apptPanel
			// 
			this.apptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.apptPanel.Controls.Add(this.mainApptDeleteButton);
			this.apptPanel.Controls.Add(this.mainApptModifyButton);
			this.apptPanel.Controls.Add(this.mainApptAddButton);
			this.apptPanel.Controls.Add(this.mainApptDGV);
			this.apptPanel.Controls.Add(this.mainApptLabel);
			this.apptPanel.Location = new System.Drawing.Point(31, 55);
			this.apptPanel.Name = "apptPanel";
			this.apptPanel.Size = new System.Drawing.Size(698, 208);
			this.apptPanel.TabIndex = 2;
			// 
			// mainApptDeleteButton
			// 
			this.mainApptDeleteButton.Location = new System.Drawing.Point(593, 162);
			this.mainApptDeleteButton.Name = "mainApptDeleteButton";
			this.mainApptDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptDeleteButton.TabIndex = 5;
			this.mainApptDeleteButton.Text = "Delete";
			this.mainApptDeleteButton.UseVisualStyleBackColor = true;
			this.mainApptDeleteButton.Click += new System.EventHandler(this.mainApptDeleteButton_Click);
			// 
			// mainApptModifyButton
			// 
			this.mainApptModifyButton.Location = new System.Drawing.Point(503, 162);
			this.mainApptModifyButton.Name = "mainApptModifyButton";
			this.mainApptModifyButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptModifyButton.TabIndex = 4;
			this.mainApptModifyButton.Text = "Modify";
			this.mainApptModifyButton.UseVisualStyleBackColor = true;
			this.mainApptModifyButton.Click += new System.EventHandler(this.mainApptModifyButton_Click);
			// 
			// mainApptAddButton
			// 
			this.mainApptAddButton.Location = new System.Drawing.Point(410, 162);
			this.mainApptAddButton.Name = "mainApptAddButton";
			this.mainApptAddButton.Size = new System.Drawing.Size(75, 23);
			this.mainApptAddButton.TabIndex = 3;
			this.mainApptAddButton.Text = "Add";
			this.mainApptAddButton.UseVisualStyleBackColor = true;
			this.mainApptAddButton.Click += new System.EventHandler(this.mainApptAddButton_Click);
			// 
			// mainApptDGV
			// 
			this.mainApptDGV.AllowUserToAddRows = false;
			this.mainApptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainApptDGV.Location = new System.Drawing.Point(19, 44);
			this.mainApptDGV.Name = "mainApptDGV";
			this.mainApptDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.mainApptDGV.Size = new System.Drawing.Size(658, 112);
			this.mainApptDGV.TabIndex = 2;
			// 
			// controlPanel
			// 
			this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.controlPanel.Controls.Add(this.customersButton);
			this.controlPanel.Controls.Add(this.apptCustomerButton);
			this.controlPanel.Controls.Add(this.apptTypesButton);
			this.controlPanel.Controls.Add(this.consultantScheButton);
			this.controlPanel.Controls.Add(this.viewApptButton);
			this.controlPanel.Controls.Add(this.controlsLabel);
			this.controlPanel.Location = new System.Drawing.Point(127, 280);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.Size = new System.Drawing.Size(512, 207);
			this.controlPanel.TabIndex = 4;
			// 
			// apptCustomerButton
			// 
			this.apptCustomerButton.Location = new System.Drawing.Point(266, 100);
			this.apptCustomerButton.Name = "apptCustomerButton";
			this.apptCustomerButton.Size = new System.Drawing.Size(219, 34);
			this.apptCustomerButton.TabIndex = 12;
			this.apptCustomerButton.Text = "Appointments by Cutomer";
			this.apptCustomerButton.UseVisualStyleBackColor = true;
			this.apptCustomerButton.Click += new System.EventHandler(this.apptCustomerButton_Click);
			// 
			// apptTypesButton
			// 
			this.apptTypesButton.Location = new System.Drawing.Point(22, 100);
			this.apptTypesButton.Name = "apptTypesButton";
			this.apptTypesButton.Size = new System.Drawing.Size(219, 34);
			this.apptTypesButton.TabIndex = 11;
			this.apptTypesButton.Text = "Appointment Types Report";
			this.apptTypesButton.UseVisualStyleBackColor = true;
			this.apptTypesButton.Click += new System.EventHandler(this.apptTypesButton_Click);
			// 
			// consultantScheButton
			// 
			this.consultantScheButton.Location = new System.Drawing.Point(266, 44);
			this.consultantScheButton.Name = "consultantScheButton";
			this.consultantScheButton.Size = new System.Drawing.Size(219, 34);
			this.consultantScheButton.TabIndex = 10;
			this.consultantScheButton.Text = "Consultant Schedule Report";
			this.consultantScheButton.UseVisualStyleBackColor = true;
			this.consultantScheButton.Click += new System.EventHandler(this.consultantScheButton_Click);
			// 
			// viewApptButton
			// 
			this.viewApptButton.Location = new System.Drawing.Point(22, 44);
			this.viewApptButton.Name = "viewApptButton";
			this.viewApptButton.Size = new System.Drawing.Size(219, 34);
			this.viewApptButton.TabIndex = 9;
			this.viewApptButton.Text = "View Appointments";
			this.viewApptButton.UseVisualStyleBackColor = true;
			this.viewApptButton.Click += new System.EventHandler(this.viewApptButton_Click);
			// 
			// controlsLabel
			// 
			this.controlsLabel.AutoSize = true;
			this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controlsLabel.Location = new System.Drawing.Point(220, 10);
			this.controlsLabel.Name = "controlsLabel";
			this.controlsLabel.Size = new System.Drawing.Size(68, 20);
			this.controlsLabel.TabIndex = 8;
			this.controlsLabel.Text = "Controls";
			// 
			// mainLogOffButton
			// 
			this.mainLogOffButton.Location = new System.Drawing.Point(567, 506);
			this.mainLogOffButton.Name = "mainLogOffButton";
			this.mainLogOffButton.Size = new System.Drawing.Size(162, 34);
			this.mainLogOffButton.TabIndex = 10;
			this.mainLogOffButton.Text = "Log Off";
			this.mainLogOffButton.UseVisualStyleBackColor = true;
			this.mainLogOffButton.Click += new System.EventHandler(this.mainLogOffButton_Click);
			// 
			// customersButton
			// 
			this.customersButton.Location = new System.Drawing.Point(149, 152);
			this.customersButton.Name = "customersButton";
			this.customersButton.Size = new System.Drawing.Size(219, 34);
			this.customersButton.TabIndex = 13;
			this.customersButton.Text = "Customers";
			this.customersButton.UseVisualStyleBackColor = true;
			this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 552);
			this.Controls.Add(this.mainLogOffButton);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.apptPanel);
			this.Controls.Add(this.label1);
			this.Name = "Main";
			this.Text = "main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.Shown += new System.EventHandler(this.Main_Shown);
			this.apptPanel.ResumeLayout(false);
			this.apptPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainApptDGV)).EndInit();
			this.controlPanel.ResumeLayout(false);
			this.controlPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainApptLabel;
        private System.Windows.Forms.Panel apptPanel;
        private System.Windows.Forms.DataGridView mainApptDGV;
        private System.Windows.Forms.Button mainApptDeleteButton;
        private System.Windows.Forms.Button mainApptModifyButton;
        private System.Windows.Forms.Button mainApptAddButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button apptCustomerButton;
        private System.Windows.Forms.Button apptTypesButton;
        private System.Windows.Forms.Button consultantScheButton;
        private System.Windows.Forms.Button viewApptButton;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.Button mainLogOffButton;
		private System.Windows.Forms.Button customersButton;
	}
}
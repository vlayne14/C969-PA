
namespace Victoria_Brown_C969_PA
{
	partial class Customers
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
			this.customersLabel = new System.Windows.Forms.Label();
			this.customersDGV = new System.Windows.Forms.DataGridView();
			this.customerNameText = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.IDText = new System.Windows.Forms.TextBox();
			this.addressLine1Text = new System.Windows.Forms.TextBox();
			this.addressLine2Text = new System.Windows.Forms.TextBox();
			this.cityComboBox = new System.Windows.Forms.ComboBox();
			this.countryComboBox = new System.Windows.Forms.ComboBox();
			this.zipCodeText = new System.Windows.Forms.TextBox();
			this.phoneText = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.addressLine1Label = new System.Windows.Forms.Label();
			this.addressLine2Label = new System.Windows.Forms.Label();
			this.cityComboBoxLabel = new System.Windows.Forms.Label();
			this.countryComboBoxLabel = new System.Windows.Forms.Label();
			this.IDLabel = new System.Windows.Forms.Label();
			this.zipCodeLabel = new System.Windows.Forms.Label();
			this.phoneLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// customersLabel
			// 
			this.customersLabel.AutoSize = true;
			this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customersLabel.Location = new System.Drawing.Point(325, 9);
			this.customersLabel.Name = "customersLabel";
			this.customersLabel.Size = new System.Drawing.Size(138, 29);
			this.customersLabel.TabIndex = 0;
			this.customersLabel.Text = "Customers";
			// 
			// customersDGV
			// 
			this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customersDGV.Location = new System.Drawing.Point(24, 54);
			this.customersDGV.MultiSelect = false;
			this.customersDGV.Name = "customersDGV";
			this.customersDGV.ReadOnly = true;
			this.customersDGV.RowHeadersVisible = false;
			this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.customersDGV.Size = new System.Drawing.Size(749, 150);
			this.customersDGV.TabIndex = 1;
			this.customersDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customersDGV_CellMouseClick);
			// 
			// customerNameText
			// 
			this.customerNameText.Location = new System.Drawing.Point(132, 239);
			this.customerNameText.Name = "customerNameText";
			this.customerNameText.Size = new System.Drawing.Size(208, 20);
			this.customerNameText.TabIndex = 2;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(651, 227);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(107, 28);
			this.addButton.TabIndex = 3;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(651, 271);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(107, 28);
			this.editButton.TabIndex = 4;
			this.editButton.Text = "Modify";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(651, 314);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(107, 28);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(651, 395);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(107, 28);
			this.deleteButton.TabIndex = 6;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(651, 437);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(107, 28);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// IDText
			// 
			this.IDText.Location = new System.Drawing.Point(427, 239);
			this.IDText.Name = "IDText";
			this.IDText.Size = new System.Drawing.Size(141, 20);
			this.IDText.TabIndex = 8;
			// 
			// addressLine1Text
			// 
			this.addressLine1Text.Location = new System.Drawing.Point(132, 283);
			this.addressLine1Text.Name = "addressLine1Text";
			this.addressLine1Text.Size = new System.Drawing.Size(436, 20);
			this.addressLine1Text.TabIndex = 9;
			// 
			// addressLine2Text
			// 
			this.addressLine2Text.Location = new System.Drawing.Point(132, 322);
			this.addressLine2Text.Name = "addressLine2Text";
			this.addressLine2Text.Size = new System.Drawing.Size(436, 20);
			this.addressLine2Text.TabIndex = 10;
			// 
			// cityComboBox
			// 
			this.cityComboBox.FormattingEnabled = true;
			this.cityComboBox.Location = new System.Drawing.Point(132, 364);
			this.cityComboBox.Name = "cityComboBox";
			this.cityComboBox.Size = new System.Drawing.Size(208, 21);
			this.cityComboBox.TabIndex = 11;
			this.cityComboBox.SelectionChangeCommitted += new System.EventHandler(this.cityComboBox_SelectionChangeCommitted);
			this.cityComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityComboBox_KeyPress);
			// 
			// countryComboBox
			// 
			this.countryComboBox.FormattingEnabled = true;
			this.countryComboBox.Location = new System.Drawing.Point(132, 407);
			this.countryComboBox.Name = "countryComboBox";
			this.countryComboBox.Size = new System.Drawing.Size(208, 21);
			this.countryComboBox.TabIndex = 12;
			this.countryComboBox.SelectionChangeCommitted += new System.EventHandler(this.countryComboBox_SelectionChangeCommitted);
			this.countryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countryComboBox_KeyPress);
			// 
			// zipCodeText
			// 
			this.zipCodeText.Location = new System.Drawing.Point(427, 365);
			this.zipCodeText.Name = "zipCodeText";
			this.zipCodeText.Size = new System.Drawing.Size(141, 20);
			this.zipCodeText.TabIndex = 13;
			this.zipCodeText.Leave += new System.EventHandler(this.zipCodeText_Leave);
			// 
			// phoneText
			// 
			this.phoneText.Location = new System.Drawing.Point(427, 408);
			this.phoneText.Name = "phoneText";
			this.phoneText.Size = new System.Drawing.Size(141, 20);
			this.phoneText.TabIndex = 14;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(30, 242);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(82, 13);
			this.nameLabel.TabIndex = 15;
			this.nameLabel.Text = "Customer Name";
			// 
			// addressLine1Label
			// 
			this.addressLine1Label.AutoSize = true;
			this.addressLine1Label.Location = new System.Drawing.Point(30, 286);
			this.addressLine1Label.Name = "addressLine1Label";
			this.addressLine1Label.Size = new System.Drawing.Size(77, 13);
			this.addressLine1Label.TabIndex = 16;
			this.addressLine1Label.Text = "Address Line 1";
			// 
			// addressLine2Label
			// 
			this.addressLine2Label.AutoSize = true;
			this.addressLine2Label.Location = new System.Drawing.Point(30, 325);
			this.addressLine2Label.Name = "addressLine2Label";
			this.addressLine2Label.Size = new System.Drawing.Size(77, 13);
			this.addressLine2Label.TabIndex = 17;
			this.addressLine2Label.Text = "Address Line 2";
			// 
			// cityComboBoxLabel
			// 
			this.cityComboBoxLabel.AutoSize = true;
			this.cityComboBoxLabel.Location = new System.Drawing.Point(83, 367);
			this.cityComboBoxLabel.Name = "cityComboBoxLabel";
			this.cityComboBoxLabel.Size = new System.Drawing.Size(24, 13);
			this.cityComboBoxLabel.TabIndex = 18;
			this.cityComboBoxLabel.Text = "City";
			// 
			// countryComboBoxLabel
			// 
			this.countryComboBoxLabel.AutoSize = true;
			this.countryComboBoxLabel.Location = new System.Drawing.Point(64, 411);
			this.countryComboBoxLabel.Name = "countryComboBoxLabel";
			this.countryComboBoxLabel.Size = new System.Drawing.Size(43, 13);
			this.countryComboBoxLabel.TabIndex = 19;
			this.countryComboBoxLabel.Text = "Country";
			// 
			// IDLabel
			// 
			this.IDLabel.AutoSize = true;
			this.IDLabel.Location = new System.Drawing.Point(386, 242);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new System.Drawing.Size(18, 13);
			this.IDLabel.TabIndex = 20;
			this.IDLabel.Text = "ID";
			// 
			// zipCodeLabel
			// 
			this.zipCodeLabel.AutoSize = true;
			this.zipCodeLabel.Location = new System.Drawing.Point(369, 368);
			this.zipCodeLabel.Name = "zipCodeLabel";
			this.zipCodeLabel.Size = new System.Drawing.Size(50, 13);
			this.zipCodeLabel.TabIndex = 21;
			this.zipCodeLabel.Text = "Zip Code";
			// 
			// phoneLabel
			// 
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.Location = new System.Drawing.Point(369, 410);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(38, 13);
			this.phoneLabel.TabIndex = 22;
			this.phoneLabel.Text = "Phone";
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(651, 352);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(107, 28);
			this.cancelButton.TabIndex = 23;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 477);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.phoneLabel);
			this.Controls.Add(this.zipCodeLabel);
			this.Controls.Add(this.IDLabel);
			this.Controls.Add(this.countryComboBoxLabel);
			this.Controls.Add(this.cityComboBoxLabel);
			this.Controls.Add(this.addressLine2Label);
			this.Controls.Add(this.addressLine1Label);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.phoneText);
			this.Controls.Add(this.zipCodeText);
			this.Controls.Add(this.countryComboBox);
			this.Controls.Add(this.cityComboBox);
			this.Controls.Add(this.addressLine2Text);
			this.Controls.Add(this.addressLine1Text);
			this.Controls.Add(this.IDText);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.customerNameText);
			this.Controls.Add(this.customersDGV);
			this.Controls.Add(this.customersLabel);
			this.Name = "Customers";
			this.Text = "Customers";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customers_FormClosed);
			this.Load += new System.EventHandler(this.Customers_Load);
			((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label customersLabel;
		private System.Windows.Forms.DataGridView customersDGV;
		private System.Windows.Forms.TextBox customerNameText;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox IDText;
		private System.Windows.Forms.TextBox addressLine1Text;
		private System.Windows.Forms.TextBox addressLine2Text;
		private System.Windows.Forms.ComboBox cityComboBox;
		private System.Windows.Forms.ComboBox countryComboBox;
		private System.Windows.Forms.TextBox zipCodeText;
		private System.Windows.Forms.TextBox phoneText;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label addressLine1Label;
		private System.Windows.Forms.Label addressLine2Label;
		private System.Windows.Forms.Label cityComboBoxLabel;
		private System.Windows.Forms.Label countryComboBoxLabel;
		private System.Windows.Forms.Label IDLabel;
		private System.Windows.Forms.Label zipCodeLabel;
		private System.Windows.Forms.Label phoneLabel;
		private System.Windows.Forms.Button cancelButton;
	}
}
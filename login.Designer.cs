namespace Victoria_Brown_C969_PA
{
    partial class login
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
			this.loginLabel = new System.Windows.Forms.Label();
			this.loginUserNameText = new System.Windows.Forms.TextBox();
			this.loginPasswordText = new System.Windows.Forms.TextBox();
			this.loginStartButton = new System.Windows.Forms.Button();
			this.loginCloseButton = new System.Windows.Forms.Button();
			this.userNameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.loginErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.loginLabel.Location = new System.Drawing.Point(140, 9);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(49, 18);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Login";
			// 
			// loginUserNameText
			// 
			this.loginUserNameText.Location = new System.Drawing.Point(64, 59);
			this.loginUserNameText.Name = "loginUserNameText";
			this.loginUserNameText.Size = new System.Drawing.Size(207, 20);
			this.loginUserNameText.TabIndex = 1;
			// 
			// loginPasswordText
			// 
			this.loginPasswordText.Location = new System.Drawing.Point(64, 108);
			this.loginPasswordText.Name = "loginPasswordText";
			this.loginPasswordText.Size = new System.Drawing.Size(207, 20);
			this.loginPasswordText.TabIndex = 2;
			this.loginPasswordText.UseSystemPasswordChar = true;
			// 
			// loginStartButton
			// 
			this.loginStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.loginStartButton.Location = new System.Drawing.Point(64, 178);
			this.loginStartButton.Name = "loginStartButton";
			this.loginStartButton.Size = new System.Drawing.Size(86, 24);
			this.loginStartButton.TabIndex = 3;
			this.loginStartButton.Text = "Start";
			this.loginStartButton.UseVisualStyleBackColor = true;
			this.loginStartButton.Click += new System.EventHandler(this.loginStartButton_Click);
			// 
			// loginCloseButton
			// 
			this.loginCloseButton.Location = new System.Drawing.Point(185, 178);
			this.loginCloseButton.Name = "loginCloseButton";
			this.loginCloseButton.Size = new System.Drawing.Size(86, 24);
			this.loginCloseButton.TabIndex = 4;
			this.loginCloseButton.Text = "Close";
			this.loginCloseButton.UseVisualStyleBackColor = true;
			this.loginCloseButton.Click += new System.EventHandler(this.loginCloseButton_Click);
			// 
			// userNameLabel
			// 
			this.userNameLabel.AutoSize = true;
			this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userNameLabel.Location = new System.Drawing.Point(61, 43);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.Size = new System.Drawing.Size(73, 15);
			this.userNameLabel.TabIndex = 5;
			this.userNameLabel.Text = "Username";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.Location = new System.Drawing.Point(61, 90);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(69, 15);
			this.passwordLabel.TabIndex = 6;
			this.passwordLabel.Text = "Password";
			// 
			// loginErrorLabel
			// 
			this.loginErrorLabel.AutoSize = true;
			this.loginErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.loginErrorLabel.Location = new System.Drawing.Point(12, 142);
			this.loginErrorLabel.Name = "loginErrorLabel";
			this.loginErrorLabel.Size = new System.Drawing.Size(69, 13);
			this.loginErrorLabel.TabIndex = 7;
			this.loginErrorLabel.Text = "Login Error";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 228);
			this.Controls.Add(this.loginErrorLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.userNameLabel);
			this.Controls.Add(this.loginCloseButton);
			this.Controls.Add(this.loginStartButton);
			this.Controls.Add(this.loginPasswordText);
			this.Controls.Add(this.loginUserNameText);
			this.Controls.Add(this.loginLabel);
			this.Name = "login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.login_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginUserNameText;
        private System.Windows.Forms.TextBox loginPasswordText;
        private System.Windows.Forms.Button loginStartButton;
        private System.Windows.Forms.Button loginCloseButton;
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label loginErrorLabel;
	}
}


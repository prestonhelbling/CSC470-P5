namespace P5_Code
{
    partial class FormLogin
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
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBoxLabel = new System.Windows.Forms.Label();
            this.PasswordTextBoxLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(136, 31);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(212, 22);
            this.UserNameTextBox.TabIndex = 0;
            this.UserNameTextBox.UseWaitCursor = true;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(136, 82);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(212, 22);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseWaitCursor = true;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UserNameTextBoxLabel
            // 
            this.UserNameTextBoxLabel.AutoSize = true;
            this.UserNameTextBoxLabel.Location = new System.Drawing.Point(44, 34);
            this.UserNameTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameTextBoxLabel.Name = "UserNameTextBoxLabel";
            this.UserNameTextBoxLabel.Size = new System.Drawing.Size(83, 17);
            this.UserNameTextBoxLabel.TabIndex = 2;
            this.UserNameTextBoxLabel.Text = "User Name:";
            this.UserNameTextBoxLabel.UseWaitCursor = true;
            // 
            // PasswordTextBoxLabel
            // 
            this.PasswordTextBoxLabel.AutoSize = true;
            this.PasswordTextBoxLabel.Location = new System.Drawing.Point(44, 85);
            this.PasswordTextBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordTextBoxLabel.Name = "PasswordTextBoxLabel";
            this.PasswordTextBoxLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordTextBoxLabel.TabIndex = 3;
            this.PasswordTextBoxLabel.Text = "Password:";
            this.PasswordTextBoxLabel.UseWaitCursor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(209, 147);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 33);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.UseWaitCursor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(47, 147);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(139, 33);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.UseWaitCursor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 218);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PasswordTextBoxLabel);
            this.Controls.Add(this.UserNameTextBoxLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserNameTextBoxLabel;
        private System.Windows.Forms.Label PasswordTextBoxLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button LoginButton;
    }
}
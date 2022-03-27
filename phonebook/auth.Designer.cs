namespace phonebook
{
    partial class auth
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
            this.RegButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.ErrorLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(67, 195);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(152, 34);
            this.RegButton.TabIndex = 0;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(55, 27);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(55, 90);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(67, 155);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(152, 34);
            this.AuthButton.TabIndex = 3;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(58, 43);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(169, 20);
            this.LogintextBox.TabIndex = 4;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(58, 106);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(169, 20);
            this.PasswordtextBox.TabIndex = 5;
            // 
            // ErrorLable
            // 
            this.ErrorLable.AutoSize = true;
            this.ErrorLable.ForeColor = System.Drawing.Color.Red;
            this.ErrorLable.Location = new System.Drawing.Point(124, 139);
            this.ErrorLable.Name = "ErrorLable";
            this.ErrorLable.Size = new System.Drawing.Size(0, 13);
            this.ErrorLable.TabIndex = 6;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 250);
            this.Controls.Add(this.ErrorLable);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.RegButton);
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label ErrorLable;
    }
}
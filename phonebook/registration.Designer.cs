namespace phonebook
{
    partial class registration
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PassConfirmTextBox = new System.Windows.Forms.TextBox();
            this.RightsComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswrodLabel = new System.Windows.Forms.Label();
            this.PassConfirmLable = new System.Windows.Forms.Label();
            this.RightsLevelLable = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(137, 24);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(184, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(137, 65);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(184, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // PassConfirmTextBox
            // 
            this.PassConfirmTextBox.Location = new System.Drawing.Point(137, 102);
            this.PassConfirmTextBox.Name = "PassConfirmTextBox";
            this.PassConfirmTextBox.PasswordChar = '*';
            this.PassConfirmTextBox.Size = new System.Drawing.Size(184, 20);
            this.PassConfirmTextBox.TabIndex = 2;
            // 
            // RightsComboBox
            // 
            this.RightsComboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.RightsComboBox.FormattingEnabled = true;
            this.RightsComboBox.Location = new System.Drawing.Point(137, 138);
            this.RightsComboBox.Name = "RightsComboBox";
            this.RightsComboBox.Size = new System.Drawing.Size(184, 21);
            this.RightsComboBox.TabIndex = 3;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(157, 209);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(164, 38);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(157, 253);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(164, 38);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(93, 27);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин";
            // 
            // PasswrodLabel
            // 
            this.PasswrodLabel.AutoSize = true;
            this.PasswrodLabel.Location = new System.Drawing.Point(86, 65);
            this.PasswrodLabel.Name = "PasswrodLabel";
            this.PasswrodLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswrodLabel.TabIndex = 7;
            this.PasswrodLabel.Text = "Пароль";
            // 
            // PassConfirmLable
            // 
            this.PassConfirmLable.AutoSize = true;
            this.PassConfirmLable.Location = new System.Drawing.Point(4, 102);
            this.PassConfirmLable.Name = "PassConfirmLable";
            this.PassConfirmLable.Size = new System.Drawing.Size(127, 13);
            this.PassConfirmLable.TabIndex = 8;
            this.PassConfirmLable.Text = "Подтверждение пароля";
            // 
            // RightsLevelLable
            // 
            this.RightsLevelLable.AutoSize = true;
            this.RightsLevelLable.Location = new System.Drawing.Point(53, 141);
            this.RightsLevelLable.Name = "RightsLevelLable";
            this.RightsLevelLable.Size = new System.Drawing.Size(78, 13);
            this.RightsLevelLable.TabIndex = 9;
            this.RightsLevelLable.Text = "Уровень прав";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(33, 185);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 10;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 296);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RightsLevelLable);
            this.Controls.Add(this.PassConfirmLable);
            this.Controls.Add(this.PasswrodLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.RightsComboBox);
            this.Controls.Add(this.PassConfirmTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PassConfirmTextBox;
        private System.Windows.Forms.ComboBox RightsComboBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswrodLabel;
        private System.Windows.Forms.Label PassConfirmLable;
        private System.Windows.Forms.Label RightsLevelLable;
        private System.Windows.Forms.Label ErrorLabel;
    }
}
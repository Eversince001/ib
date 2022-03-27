
namespace phonebook
{
    partial class Phonebook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhoneBookList = new System.Windows.Forms.ListView();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FIOTextBox = new System.Windows.Forms.TextBox();
            this.PhonenumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearTextBoxesButton = new System.Windows.Forms.Button();
            this.loglabel = new System.Windows.Forms.Label();
            this.UsersButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneBookList
            // 
            this.PhoneBookList.HideSelection = false;
            this.PhoneBookList.Location = new System.Drawing.Point(23, 42);
            this.PhoneBookList.Name = "PhoneBookList";
            this.PhoneBookList.Size = new System.Drawing.Size(642, 260);
            this.PhoneBookList.TabIndex = 0;
            this.PhoneBookList.UseCompatibleStateImageBehavior = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeButton.Location = new System.Drawing.Point(671, 42);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(117, 36);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Location = new System.Drawing.Point(671, 84);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(117, 36);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Location = new System.Drawing.Point(671, 345);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 36);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchButton.Location = new System.Drawing.Point(528, 402);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(117, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FIOTextBox
            // 
            this.FIOTextBox.Location = new System.Drawing.Point(23, 354);
            this.FIOTextBox.Name = "FIOTextBox";
            this.FIOTextBox.Size = new System.Drawing.Size(277, 20);
            this.FIOTextBox.TabIndex = 7;
            // 
            // PhonenumberTextBox
            // 
            this.PhonenumberTextBox.Location = new System.Drawing.Point(368, 354);
            this.PhonenumberTextBox.Name = "PhonenumberTextBox";
            this.PhonenumberTextBox.Size = new System.Drawing.Size(277, 20);
            this.PhonenumberTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер";
            // 
            // ClearTextBoxesButton
            // 
            this.ClearTextBoxesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearTextBoxesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearTextBoxesButton.Location = new System.Drawing.Point(368, 402);
            this.ClearTextBoxesButton.Name = "ClearTextBoxesButton";
            this.ClearTextBoxesButton.Size = new System.Drawing.Size(117, 36);
            this.ClearTextBoxesButton.TabIndex = 12;
            this.ClearTextBoxesButton.Text = "Очистить поля ввода";
            this.ClearTextBoxesButton.UseVisualStyleBackColor = true;
            this.ClearTextBoxesButton.Click += new System.EventHandler(this.ClearTextBoxesButton_Click);
            // 
            // loglabel
            // 
            this.loglabel.AutoSize = true;
            this.loglabel.Location = new System.Drawing.Point(12, 9);
            this.loglabel.Name = "loglabel";
            this.loglabel.Size = new System.Drawing.Size(169, 13);
            this.loglabel.TabIndex = 13;
            this.loglabel.Text = "Вы вошли под пользователем:  ";
            // 
            // UsersButton
            // 
            this.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UsersButton.Location = new System.Drawing.Point(671, 126);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(117, 36);
            this.UsersButton.TabIndex = 14;
            this.UsersButton.Text = "Пользователи";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegButton.Location = new System.Drawing.Point(671, 168);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(117, 36);
            this.RegButton.TabIndex = 15;
            this.RegButton.Text = "Зарегистрировать";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Location = new System.Drawing.Point(23, 402);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 36);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Phonebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.loglabel);
            this.Controls.Add(this.ClearTextBoxesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhonenumberTextBox);
            this.Controls.Add(this.FIOTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.PhoneBookList);
            this.Name = "Phonebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонная книга";
            this.Load += new System.EventHandler(this.Phonebook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PhoneBookList;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FIOTextBox;
        private System.Windows.Forms.TextBox PhonenumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearTextBoxesButton;
        private System.Windows.Forms.Label loglabel;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


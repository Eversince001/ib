using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace phonebook
{
    public partial class registration : Form
    {
        private Form back;
        private List<List<string>> users;
        private string path = Directory.GetCurrentDirectory();
        private bool mode;
        public registration(Form back, ref List<List<string>> usrs, bool mode)
        {
            InitializeComponent();
            this.back = back;
            this.users = usrs;
            this.mode = mode;
            if (!mode)
            {
                RightsComboBox.Visible = false;
                RightsLevelLable.Visible = false;
            }
        }

        private void registration_Load(object sender, EventArgs e)
        {
            RightsComboBox.Items.Add("Пользователь");
            RightsComboBox.Items.Add("Администратор");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmpassword = PassConfirmTextBox.Text;
            string lvl = RightsComboBox.Text;

            if (login.Length < 3)
            {
                ErrorLabel.Text = "Слишком короткий логин";
                return;
            }
            if (password.Length < 5)
            {
                ErrorLabel.Text = "Слишком короткий пароль";
                return;
            }
            if (password != confirmpassword)
            {
                ErrorLabel.Text = "Пароли не совпадают";
                return;
            }
            if (mode)
            {
                if (lvl != "Администратор" && lvl != "Пользователь")
                {
                    ErrorLabel.Text = "В поле уровень прав некорректные данные";
                    return;
                }

            }
            else
            {
                lvl = "Пользователь";
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (login == users[i][0])
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
            }

            List<string> user = new List<string>();
            user.Add(login);
            ErrorLabel.Text = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                string hash = GetHash(sha256Hash, password);
                user.Add(hash);
            }
            if (lvl == "Администратор")
            {
                user.Add("Администратор");
            }
            if (lvl == "Пользователь")
            {
                user.Add("Пользователь");
            }
            users.Add(user);
            string jsonUsers = Newtonsoft.Json.JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path + @"\users.json", jsonUsers);
            MessageBox.Show("Вы успешно зарегистрировались!");

        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}

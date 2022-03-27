using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;

namespace phonebook
{
    public partial class auth : Form
    {
        private string path = Directory.GetCurrentDirectory();
        private List<List<string>> usrs;
        public auth()
        {
            InitializeComponent();
            usrs = new List<List<string>>();
            Load();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Form reg = new registration(this, ref usrs, false);
            this.Hide();
            reg.Show();
        }

        private void Load()
        {
            if (File.Exists(path + @"\users.json"))
            {
                string jsonUsers = File.ReadAllText(path + @"\users.json");
                if (jsonUsers.Length != 0)
                {
                    usrs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<List<string>>>(jsonUsers);
                }
            }
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string login = LogintextBox.Text; int isExist = -1;
            string password = PasswordtextBox.Text;
            for (int i = 0; i < usrs.Count; i++)
            {
                if (login == usrs[i][0])
                {
                    isExist = i;
                    break;
                }
            }
            if (isExist > -1)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    string hash = GetHash(sha256Hash, password);

                    if (hash == usrs[isExist][1])
                    {
                        Form phone = new Phonebook(this, ref usrs, isExist);
                        this.Hide();
                        phone.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
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

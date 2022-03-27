using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace phonebook
{
    public partial class usrs : Form
    {
        private List<List<string>> users;
        private Form back;
        private string path = Directory.GetCurrentDirectory();
        public usrs(Form back, ref List<List<string>> usrs)
        {
            InitializeComponent();
            this.users = usrs;
            this.back = back;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[1].Value != null)
                    users[i][2] = dataGridView.Rows[i].Cells[1].Value.ToString();
            }

            string jsonUsers = Newtonsoft.Json.JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path + @"\users.json", jsonUsers);

            this.Close();
            back.Show();
        }

        private void usrs_Load(object sender, EventArgs e)
        {
           // dataGridView.Columns.Add("login", "Логин");
           // dataGridView.Columns.Add("rights", "Права доступа");
            dataGridView.Columns[0].Width = 242;
            dataGridView.Columns[1].Width = 242;
            //dataGridView.CellContentDoubleClick += new DataGridViewCellEventHandler(CreateComboboxOnDataGridView);


            //DataGridViewComboBoxColumn assignedToColumn = new DataGridViewComboBoxColumn();
            //assignedToColumn.HeaderText = "Права доступа";
            // assignedToColumn.Items.Add("Администартор");
            // assignedToColumn.Items.Add("Пользователь");
            // string[] rights = new string[] { "Администартор", "Пользователь"};
            //(dataGridView.Columns[1] as DataGridViewComboBoxColumn).DataSource = getRigths();

            var combobox = (DataGridViewComboBoxColumn)dataGridView.Columns["rights"];
            combobox.DisplayMember = "Name";
            combobox.ValueMember = "ID";
            combobox.DataSource = getRigths();
            //dataGridView.DataSource = getUsers();
            for (int i = 0; i < users.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = users[i][0];
                //dataGridView.Rows[i].Cells[1].Value = users[i][2];
            }
        }

        private List<Category> getRigths()
        {
            return new List<Category> {
                new Category { Name = "Администартор", ID = "Администратор" },
                new Category { Name = "Пользователь", ID = "Пользователь" }
            };
        }

        private List<Users> getUsers()
        {
            List<Users> usr = new List<Users>();

            for (int i = 0; i < users.Count; i++)
            {
                usr.Add(new Users { login = users[i][0], rights = users[i][2]});
            }

            return usr;
        }

    }

    public class Category
    {
        public string Name { get; set; }
        public string ID { get; set; }
    }

    public class Users
    {
        public string login { get; set; }
        public string rights { get; set; }
    }
}

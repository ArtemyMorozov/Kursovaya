using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya1._0
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            BDAirport db = new BDAirport();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `USERS` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][3].ToString() == "admin")
                    {
                        status.admin = 1;
                    }
                    else if (table.Rows[i][3].ToString() == "user")
                    {
                        status.admin = 0;
                    }
                }
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            db.closeConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 29);
            loginField.Text = "login";
            loginField.ForeColor = Color.Gray;
            passField.Text = "password";
            passField.ForeColor = Color.Gray;
            passField.UseSystemPasswordChar = false;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "login";
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
                passField.UseSystemPasswordChar = true;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.ForeColor = Color.Gray;
                passField.Text = "password";
                passField.UseSystemPasswordChar = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintTicketForm printTicketForm = new PrintTicketForm();
            printTicketForm.Show();
        }
    }
}

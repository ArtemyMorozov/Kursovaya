using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya1._0
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private BDAirport db;

        private void registration_Load(object sender, EventArgs e)
        {
            loginField.Text = "login";
            loginField.ForeColor = Color.Gray;
            password.Text = "password";
            password.ForeColor = Color.Gray;
            password.UseSystemPasswordChar = false;
            confirmPassword.Text = "password";
            confirmPassword.ForeColor = Color.Gray;
            confirmPassword.UseSystemPasswordChar = false;
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

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void confirmPassword_Enter(object sender, EventArgs e)
        {
            if (confirmPassword.Text == "password")
            {
                confirmPassword.Text = "";
                confirmPassword.ForeColor = Color.Black;
                confirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.ForeColor = Color.Gray;
                password.Text = "password";
                password.UseSystemPasswordChar = false;
            }
        }

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            if (confirmPassword.Text == "")
            {
                confirmPassword.ForeColor = Color.Gray;
                confirmPassword.Text = "password";
                confirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void reg_Click(object sender, EventArgs e)
        {

            db = new BDAirport();
            db.getConnection();

            bool flag = true;

            if (password.Text != confirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                flag = false;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM  USERS", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            ArrayList list = new ArrayList();

            int id = table.Rows.Count + 1;
            string type = "user";

            if (loginField.Text == "" || loginField.Text == " " || loginField.Text == "login")
            {
                MessageBox.Show("Ошибка ввода данных. Проверьте данные и повторите попытку");
                flag = false;
            }

            else if (password.Text == " " || password.Text == "" || password.Text == "password")
            {
                MessageBox.Show("Ошибка ввода данных. Проверьте данные и повторите попытку");
                flag = false;
            }
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (loginField.Text == table.Rows[i][1].ToString())
                    {
                        MessageBox.Show("Такой пользователь уже зарегестрирован");
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                db.openConnection();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                     MySqlCommand command2 = new MySqlCommand("INSERT INTO USERS (id, login, pass, type) VALUES(@id, @login, @pass, @type)", db.getConnection());
                     command2.Parameters.AddWithValue("id", id);
                     command2.Parameters.AddWithValue("login", loginField.Text);
                     command2.Parameters.AddWithValue("pass", password.Text);
                     command2.Parameters.AddWithValue("type", type);
                     command2.ExecuteNonQuery();
                }
                MessageBox.Show("Пользователь успешно зарегестрирован!");
                this.Hide();
                Authentication Form1 = new Authentication();
                Form1.Show();
            }
            db.closeConnection();
            flag = true;


        }

        private void registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Authentication Form1 = new Authentication();
            Form1.Show();
        }
    }
}

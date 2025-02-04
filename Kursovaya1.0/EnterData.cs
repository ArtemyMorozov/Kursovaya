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

namespace Kursovaya1._0
{
    public partial class EnterData : Form
    {
        public EnterData()
        {
            InitializeComponent();
        }

        private BDAirport db;
        private void Oformit_Click(object sender, EventArgs e)
        {
            if (FIO.Text == "" || FIO.Text == " ")
            {
                MessageBox.Show("ФИО не введено! Повторите попытку.");
            }
            else if (Birthday.Text.Length < 10)
            {
                MessageBox.Show("Дата рождения не введена. Повторите попытку.");
            }
            else if (Passport.Text.Length < 11)
            {
                MessageBox.Show("Серия или номер паспорта введены неверно. Повторите попытку.");
            }
            else if (Email.Text == "" || Email.Text == " ")
            {
                MessageBox.Show("Email введен неверно. Повторите попытку.");
            }

            else
            {
                status.dBirth = Birthday.Text;
                status.dPass = Passport.Text;
                status.dName = FIO.Text;
                status.dMail = Email.Text;

                db = new BDAirport();
                db.getConnection();
                db.openConnection();
                MySqlCommand command1 = new MySqlCommand("INSERT INTO soldTickets (name, whereToGo, departureDate, pass, birthday, email) VALUES(@name, @whereToGo, @departureDate, @pass, @birthday, @email)", db.getConnection());
                command1.Parameters.AddWithValue("name", status.dName);
                command1.Parameters.AddWithValue("whereToGo", status.departure);
                command1.Parameters.AddWithValue("departureDate", status.dDate);
                command1.Parameters.AddWithValue("pass", status.dPass);
                command1.Parameters.AddWithValue("birthday", status.dBirth);
                command1.Parameters.AddWithValue("email", status.dMail);
                command1.ExecuteNonQuery();

                db.closeConnection();

                if (status.AmountOfTickets > 1 && status.morethanone == 2)
                {
                    status.morethanone = 3;
                    this.Hide();
                    Pay pay = new Pay();
                    pay.Show();

                }
                else if (status.AmountOfTickets >= 1 && status.morethanone == 3)
                {
                    this.Hide();
                    PrintTicketForm printTicketForm = new PrintTicketForm();
                    printTicketForm.Show();
                }
                else if (status.AmountOfTickets == 1 && status.morethanone == 1)
                {
                    this.Hide();
                    Pay pay = new Pay();
                    pay.Show();
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Oformit.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                Oformit.Enabled = false;
            }
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key) && !char.IsLetter(key) && (key != '@') && (key != '-') && (key != '.'))
            {
                e.Handled = true;
            }
        }

        private void FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsControl(key) && !char.IsLetter(key) && key!= ' ')
            {
                e.Handled = true;
            }
        }
    }
}

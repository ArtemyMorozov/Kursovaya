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
    public partial class Edit : Form
    {
        private BDAirport db;
        public Edit()
        {
            InitializeComponent();
        }
        private void edit_Load(object sender, EventArgs e)
        {
            db = new BDAirport();

            MySqlCommand command = new MySqlCommand("SELECT * FROM  soldTickets", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            soldTicketsView.DataSource = table;
            db.closeConnection();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  schedule", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            db = new BDAirport();
            db.getConnection();
            db.openConnection();

            int id = table.Rows.Count + 1;

            if (cost.Text == "0" || cost.Text == "")
            {
                MessageBox.Show("Цена указана неверно");
            }
            else if (seats.Text == "0" || seats.Text == "")
            {
                MessageBox.Show("Количество мест указано неверно");
            }
            else if (City.Text == "" || City.Text == " ")
            {
                MessageBox.Show("Пункт назначения указан неверно!");
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand("INSERT INTO schedule (id, whereToGo, departureDate, travelTime, arrivalDate, availableSeats, cost) VALUES(@id, @whereToGo, @departureDate, @travelTime, @arrivalDate, @availableSeats, @cost)", db.getConnection());
                command1.Parameters.AddWithValue("id", id);
                command1.Parameters.AddWithValue("whereToGo", City.Text);
                command1.Parameters.AddWithValue("departureDate", date1.Text);
                command1.Parameters.AddWithValue("travelTime", time.Text);
                command1.Parameters.AddWithValue("arrivalDate", date2.Text);
                command1.Parameters.AddWithValue("availableSeats", seats.Text);
                command1.Parameters.AddWithValue("cost", cost.Text);
                command1.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
            }
        }

        private void City_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsLetter(key) && (key != '-') && !char.IsControl(key) && (key != ' '))
            {
                e.Handled = true;
            }
        }

        private void seats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void time_Click(object sender, EventArgs e)
        {
            {
                time.SelectionStart = 0;
            }
        }

        private void date1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void date2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  schedule", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            db = new BDAirport();
            db.getConnection();
            db.openConnection();

            int id = table.Rows.Count;

            if (City.Text == "" || City.Text == " ")
            {
                MessageBox.Show("Пункт назначения указан неверно!");
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand("DELETE FROM schedule WHERE whereToGo = @whereToGo AND departureDate = @departureDate", db.getConnection());
                command1.Parameters.AddWithValue("whereToGo", City.Text);
                command1.Parameters.AddWithValue("departureDate", date1.Text);
                command1.ExecuteNonQuery();
                MessageBox.Show("Успешно!");
            }
        }


        private void cCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsLetter(key) && (key != '-') && !char.IsControl(key) && (key != ' '))
            {
                e.Handled = true;
            }
        }

        private void cDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }

        private void obmovit_Click(object sender, EventArgs e)
        {


            MySqlCommand command = new MySqlCommand("SELECT * FROM  schedule", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            int id = table.Rows.Count + 1;

            db = new BDAirport();
            db.getConnection();
            db.openConnection();
            bool check = false;
            for (int i = 0; i < table.Rows.Count; i++)
            {

                if ((cCity.Text == table.Rows[i][1].ToString()) && (cDate.Text == table.Rows[i][2].ToString()))
                {
                    string kol = cSeats.Text;
                    int amount = Int32.Parse(kol);
                    MySqlCommand command1 = new MySqlCommand("UPDATE schedule SET availableSeats = @availableSeats WHERE whereToGo = @whereToGo AND departureDate= @departureDate", db.getConnection());

                    command1.Parameters.AddWithValue("availableSeats", Convert.ToInt32(amount));
                    command1.Parameters.AddWithValue("whereToGo", cCity.Text);
                    command1.Parameters.AddWithValue("departuredate", cDate.Text);
                    command1.ExecuteNonQuery();
                    db.closeConnection();
                    check = true;
                    MessageBox.Show("Успешно!");
                }
            }
            if (check == false)
            {
                MessageBox.Show("Указанного рейса не существует!");
            }
        }

        private void cSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(key) && !char.IsControl(key))
            {
                e.Handled = true;
            }
        }
    }
}

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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya1._0
{
    public partial class MainForm : Form
    {
        private BDAirport db;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) 
        {
           // date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            db = new BDAirport();
            db.getConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            //создать Массив для сравнения значений из БД
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (!list.Contains(table.Rows[i][1].ToString()))
                {
                    list.Add(table.Rows[i][1].ToString());
                }
            }

            ChooseWhereToGo.DataSource = list;
            ChooseWhereToGo.SelectedIndex = -1;

            if (ChooseWhereToGo.SelectedIndex == -1)
            {
                ClosestTime.Text = "";
            }
            FreeSeats.Text = "Не выбрано время";

            ClosestTime.SelectedIndex = -1;
            List<string> list2 = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" };
            ClosestTime.DataSource = list2;

            date.SelectedIndex = -1;
            ClosestTime.SelectedIndex = -1;
            ClosestTime.Text = "";
        }

        private void ChooseWhereToGo_SelectedIndexChanged(object sender, EventArgs e)
        {
            date.SelectedIndex = -1;
            ClosestTime.SelectedIndex = -1;
            ClosestTime.Text = "";

            string city = ChooseWhereToGo.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            //создать массив типа DateTime для сравнения даты и времени из бд
            ArrayList list = new ArrayList();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][1].ToString() == city)
                {
                    if (!list.Contains(table.Rows[i][2]))
                    {
                        list.Add(table.Rows[i][2]);
                    }
                }
            }

            //найти в списке ближайшее время
            //DateTime now = DateTime.Now;
            //DateTime closest = DateTime.MaxValue;
            //foreach (DateTime dt in list)
            //{
            //    if (dt > now && dt < closest)
            //    {
            //        closest = dt;
            //    }
            //}
            //вывести ближайшее время в ClosestTime
           // ClosestTime.Text = closest.ToString("f");

        
            string dest = ChooseWhereToGo.Text;
            ArrayList list2 = new ArrayList();
            if (gTime.Checked == false)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (dest == table.Rows[i][1].ToString())
                    {
                        list2.Add(table.Rows[i][2].ToString());
                    }
                }
                date.DataSource = list2;
                date.SelectedIndex = -1;
            }


            int seats;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (dest == table.Rows[i][2].ToString())
                {
                    seats = Convert.ToInt32(table.Rows[i][5]);
                    FreeSeats.Text = seats.ToString();
                }
            }

        }
         
        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = date.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            string transfer = "";
            int seats;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][2].ToString())
                {
                    transfer = table.Rows[i][3].ToString();
                    seats = Convert.ToInt32(table.Rows[i][5]);
                    FreeSeats.Text = seats.ToString();
                }
            }
            TransferTextDate.Text = transfer.ToString();
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            bool find = true;
            if (ChooseWhereToGo.Text == " " || ChooseWhereToGo.Text == "")
            {
                MessageBox.Show("Не выбран пункт назначения!");
                return;
            }
            else if (date.Text == "" || date.Text == " ")
            {
                MessageBox.Show("Не выбрана дата!");
                return;
            }
            else if (TicketsAmmount.Text == "" || TicketsAmmount.Text == " " || TicketsAmmount.Text == "0")
            {
                MessageBox.Show("Не указано количество билетов!");
                return;
            }
            else if (FreeSeats.Text == "" || FreeSeats.Text == " " || FreeSeats.Text == "0")
            {
                MessageBox.Show("Нет свободных мест!");
                return;
            }
            else
            {
                DataTable table = new DataTable();

                MySqlCommand com = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                db.openConnection();
                adapter.Fill(table);

                int n = Convert.ToInt32(TicketsAmmount.Text);
                int m = Convert.ToInt32(FreeSeats.Text);
                
                if (n > m)
                {
                    MessageBox.Show("Недостаточно свободных мест!");
                    return;
                }

                string data = date.Text;
                int number = 0;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (data == table.Rows[i][2].ToString())
                    {
                        number = i + 1;
                        break;
                    }
                }
                
                int minus = m - n;

                string place = ChooseWhereToGo.Text;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (place != table.Rows[i][1].ToString())
                    {
                        continue;
                    }
                    else
                    {
                        find = false;
                    }
                }
                if (find == true)
                {
                    MessageBox.Show("Билетов в выбранное место нет!");
                    ChooseWhereToGo.Text = "";
                    date.Text = "";
                    TicketsAmmount.Clear();
                    ClosestTime.SelectedIndex= -1;
                    FreeSeats.Clear();
                    PriceText.Clear();
                    TransferTextDate.Clear();
                    return;
                }

                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand("UPDATE schedule SET availableSeats = @availableSeats WHERE id = @id", db.getConnection());
                command.Parameters.AddWithValue("@availableSeats", Convert.ToInt32(minus));
                command.Parameters.AddWithValue("@id", number);
                // выполняем запрос
                command.ExecuteNonQuery();

                status.departure = ChooseWhereToGo.Text;
                status.dDate = date.Text;
                status.dAmount = PriceText.Text;

                EnterData enterData = new EnterData();
                enterData.Show();
                //MessageBox.Show("Билет оформлен успешно!");
                ChooseWhereToGo.Text = "";
                date.Text = "";
                TicketsAmmount.Clear();
                ClosestTime.SelectedIndex= -1;
                FreeSeats.Clear();
                PriceText.Clear();
                TransferTextDate.Clear();
            }
        }
        
        private void TicketsAmmount_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            int n;
            string data = date.Text;
            string price = "0";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (data == table.Rows[i][2].ToString())
                {
                    price = table.Rows[i][6].ToString();
                }
            }
            n = Convert.ToInt32(price);
            if (TicketsAmmount.Text != "")
            {
                int m;
                if (!int.TryParse(TicketsAmmount.Text, out m))
                {
                    MessageBox.Show("Введите число");
                    TicketsAmmount.Text = "0";
                }
                else if (m < 0)
                {
                    MessageBox.Show("Введите положительное число");
                    TicketsAmmount.Text = "0";
                }
                else
                {
                    int sum = m * n;
                    PriceText.Text = sum.ToString();
                    status.AmountOfTickets = m;
                    if (m > 1)
                    {
                        status.morethanone = 2;
                    }
                    if (m == 1)
                    {
                        status.morethanone = 1;
                    }
                }
            }
            else
                PriceText.Text = "0";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ClosestTime_Click(object sender, EventArgs e)
        {
            if (ClosestTime.Text == "Длительность перелета")
            {
                ClosestTime.Text = "";
            }
        }

        private void gTime_CheckedChanged(object sender, EventArgs e)
        {
            if (gTime.Checked == true)
            {
                ClosestTime.Enabled = true;
            }
            else if (gTime.Checked == false)
            {
                ClosestTime.SelectedIndex= -1;
                ClosestTime.Enabled = false;
            }
        }

        private void ClosestTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            e.Handled = true;
        }

        private void ClosestTime_SelectedIndexChanged(object sender, EventArgs e)
        {

            db = new BDAirport();
            db.getConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM schedule", db.getConnection());
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            string dest = ChooseWhereToGo.Text;
            string time;
            int baseTime;
            int timeIndex = ClosestTime.SelectedIndex + 1;
            ArrayList list2 = new ArrayList();
            ArrayList list3 = new ArrayList();

            if (gTime.Checked == true)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    time = table.Rows[i][3].ToString();
                    string firstNumberString = Regex.Match(time, @"\d+").Value;
                    baseTime = int.Parse(firstNumberString);
                    //textBox1.Text = baseTime.ToString();
                    if ((dest == table.Rows[i][1].ToString()) && (timeIndex >= baseTime + 1))
                    {
                        list3.Add(table.Rows[i][2].ToString());
                    }
                }
                date.DataSource = list3;
                date.SelectedIndex = -1;
            }
        }

        private void admin_Click(object sender, EventArgs e)
        {
            if (status.admin == 0)
            {
                MessageBox.Show("Недостаточно прав!");
            }
            else if (status.admin == 1) 
            {
                Edit edit = new Edit();
                edit.Show();
            }
        }

        private void date_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            e.Handled = true;
        }
    }
}

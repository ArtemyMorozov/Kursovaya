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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Kursovaya1._0
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }
        private BDAirport db;

        private void pay_Load(object sender, EventArgs e)
        {
            amount.Text = status.dAmount;
        }

        private void gb_CheckedChanged(object sender, EventArgs e)
        {
            if (gb.Checked == true)
            {
                gn.Checked = false;
                mm.Visible = true;
                gg.Visible = true;
                cDate.Visible = true;
                number.Visible = true;
                tNumber.Visible = true;
                tPay.Visible = false;
                gNal.Visible = false;
            }
        }

        private void gn_CheckedChanged(object sender, EventArgs e)
        {
            if (gn.Checked == true)
            {
                gb.Checked = false;
                mm.Visible = false;
                gg.Visible = false;
                cDate.Visible = false;
                number.Visible = false;
                tNumber.Visible = false;
                tPay.Visible = true;
                gNal.Visible = true;
            }
        }

        private void PushPay_Click(object sender, EventArgs e)
        {
            db = new BDAirport();
            db.getConnection();

            if (gb.Checked == true)
            {
                if (number.Text == null || number.Text.Length < 19)
                {
                    MessageBox.Show("Номер карты введен неверно!");
                }
                if (gg.Text.Length < 2 || mm.Text.Length<2)
                {
                    MessageBox.Show("Срок действия карты указан неверно!");
                }
                else
                {
                    MessageBox.Show("Оплата прошла успешно!");

                    this.Hide();
                    PrintTicketForm printTicketForm = new PrintTicketForm();
                    printTicketForm.Show();
                }
            }
            if (gn.Checked == true)
            {
                if (gNal.Checked == false)
                {
                    MessageBox.Show("Оплата не прошла.Повторите попытку!");
                }
                else if (gNal.Checked == true)
                {
                    MessageBox.Show("Оплата прошла успешно!");

                    this.Hide();
                    PrintTicketForm printTicketForm = new PrintTicketForm();
                    printTicketForm.Show();
                }
            }


        }
    }   
}

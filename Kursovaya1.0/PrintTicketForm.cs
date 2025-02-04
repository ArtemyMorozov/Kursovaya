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
    public partial class PrintTicketForm : Form
    {
        public PrintTicketForm()
        {
            InitializeComponent();
        }

        private void PrintTicketForm_Load(object sender, EventArgs e)
        {
            name.Text = status.dName;
            departure.Text = status.departure;
            date.Text = status.dDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Билет печатается");
            if (status.AmountOfTickets != 1)
            {
                status.AmountOfTickets = status.AmountOfTickets - 1;
                this. Hide();
                EnterData enterData = new EnterData();
                enterData.Show();
            }
            else if (status.AmountOfTickets == 1)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();    
            }
        }
    }
}

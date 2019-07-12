using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Travels_Lanka
{
    public partial class Dashboard : Form
    {
        Timer t = new Timer();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {

        }

        private void TimeLbl_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            dateLbl.Text = DateTime.Now.ToLongDateString();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
            titleLbl.Text = "Home";
        }

        private void PackagesBtn_Click(object sender, EventArgs e)
        {
            packagesUC1.BringToFront();
            titleLbl.Text = "Packages";
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            reservationUC1.BringToFront();
            titleLbl.Text = "Reservation";
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            customerUC1.BringToFront();
            titleLbl.Text = "Customer";
        }

        private void VehiclesBtn_Click(object sender, EventArgs e)
        {
            vehiclesUC1.BringToFront();
            titleLbl.Text = "Vehicles";
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            paymentUC1.BringToFront();
            titleLbl.Text = "Payment";
        }
    }
}

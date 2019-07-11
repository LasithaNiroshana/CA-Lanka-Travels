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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            reservationUC1.BringToFront();

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            homeUC1.BringToFront();
        }

        private void PackagesBtn_Click(object sender, EventArgs e)
        {
            packagesUC1.BringToFront();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            customerUC1.BringToFront();
        }

        private void VehiclesBtn_Click(object sender, EventArgs e)
        {
            vehiclesUC1.BringToFront();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            packagesUC1.BringToFront();
        }
    }
}

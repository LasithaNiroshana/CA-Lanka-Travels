using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_Travels_Lanka
{
    public partial class reservationUC : UserControl
    {
        public reservationUC()
        {
            InitializeComponent();
        }

        private void ResAddBtn_Click(object sender, EventArgs e)
        {
            addReservation ar = new addReservation();
            ar.ShowDialog();
        }
    }
}

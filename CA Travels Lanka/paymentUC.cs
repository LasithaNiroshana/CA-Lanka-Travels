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
    public partial class paymentUC : UserControl
    {
        public paymentUC()
        {
            InitializeComponent();
        }

        private void CusPayBtn_Click(object sender, EventArgs e)
        {
            addCusPayment acp = new addCusPayment();
            acp.ShowDialog();
        }

        private void OwnAddBtn_Click(object sender, EventArgs e)
        {
            addOwnerPayment aow = new addOwnerPayment();
            aow.ShowDialog();
        }
    }
}

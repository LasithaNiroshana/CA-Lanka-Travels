﻿using System;
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
    public partial class vehiclesUC : UserControl
    {
        public vehiclesUC()
        {
            InitializeComponent();
        }

        private void VehiAddBtn_Click(object sender, EventArgs e)
        {
            addVehicle av = new addVehicle();
            av.ShowDialog();
        }
    }
}

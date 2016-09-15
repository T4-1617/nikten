using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvailibleCars_Click(object sender, EventArgs e)
        {
            pnlRentCar.Visible = true;
        }

        private void btnOpenAddCar_Click(object sender, EventArgs e)
        {
            pnlAddCar.Visible = true;
        }

        private void btnRentedCars_Click(object sender, EventArgs e)
        {
            pnlRentedCars.Visible = true;
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
            pnlRentCar.Visible = false;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            pnlRentedCars.Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            pnlAddCar.Visible = false;
        }
    }
}

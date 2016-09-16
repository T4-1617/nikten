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
        System.Collections.ArrayList Car;
        public Form1()
        {
            InitializeComponent();
            Car = new System.Collections.ArrayList();

            Car.Add(new RentedCars() { Maker = "Tyota", Color = "Röd", RegristerNumber = "AGD 582", Rented = false});
            Car.Add(new RentedCars() { Maker = "Ople", Color = "Blå", RegristerNumber = "GSF 153", Rented = false });
            Car.Add(new RentedCars() { Maker = "Volvo", Color = "Svart", RegristerNumber = "KFV 264", Rented = false });
        }

        private void btnAvailibleCars_Click(object sender, EventArgs e)
        {
            pnlRentCar.Visible = true;
            PrintNotRentedCars();
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

        public void PrintNotRentedCars()
        {
            lstAvalibleCars.Items.Clear();
            foreach (RentedCars x in Car)
            {
                if (x.Rented == false)
                {
                    lstAvalibleCars.Items.Add(x.CarName());
                }
            }
        }
    }
}

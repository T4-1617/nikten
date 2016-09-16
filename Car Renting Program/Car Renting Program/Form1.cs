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

            Car.Add(new Cars() { Maker = "Tyota", Color = "Röd", RegristerNumber = "AGD 582", Rented = false});
            Car.Add(new Cars() { Maker = "Ople", Color = "Blå", RegristerNumber = "GSF 153", Rented = false });
            Car.Add(new Cars() { Maker = "Volvo", Color = "Svart", RegristerNumber = "KFV 264", Rented = false });
        }

        private void btnAvailibleCars_Click(object sender, EventArgs e)
        {
            GUI();
            pnlRentCar.Visible = true;
            PrintCars();
        }

        private void btnOpenAddCar_Click(object sender, EventArgs e)
        {
            GUI();
            pnlAddCar.Visible = true;
        }

        private void btnRentedCars_Click(object sender, EventArgs e)
        {
            GUI();
            pnlRentedCars.Visible = true;
            PrintCars();
        }

        private void btnRentCar_Click(object sender, EventArgs e)
        {
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
        }


        
        public void GUI()
        {
            pnlAddCar.Visible = false;
            pnlRentCar.Visible = false;
            pnlRentedCars.Visible = false;
            pnlThankYouRent.Visible = false;
            pnlThankYouRented.Visible = false;
        }


        public void PrintCars()
        {
            lstAvalibleCars.Items.Clear();
            foreach (RentedCars x in Car)
            {
                switch (x.Rented)
                {
                    case (false):
                        lstAvalibleCars.Items.Add(x.CarName());
                        break;

                    case (true):
                        lstRentedCars.Items.Add(x.CarName());
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

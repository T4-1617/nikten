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
        System.Collections.ArrayList Cars;
        public int AmountOfCars = 3;
        public Car a;


        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            Cars.Add(new Car() { Maker = "Tyota", Color = "Röd", RegristerNumber = "AGD 582", Rented = false, Modle = "V38"});
            Cars.Add(new Car() { Maker = "Ople", Color = "Blå", RegristerNumber = "GSF 153", Rented = false, Modle = "Winter55"});
            Cars.Add(new Car() { Maker = "Volvo", Color = "Svart", RegristerNumber = "KFV 264", Rented = false, Modle = "JH73"});
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
            a = (Car)lstAvalibleCars.SelectedItem;
            a.Rented = true;
            PrintCars();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AmountOfCars++;
            Cars.Add(new Car() { Maker = tbxMaker.Text, Color = tbxColor.Text, RegristerNumber = tbxRegrristerNumber.Text,
                Rented = false, Modle = tbxModel.Text});
            tbxMaker.Clear();
            tbxColor.Clear();
            tbxModel.Clear();
            tbxRegrristerNumber.Clear();
            lblNumberOfCarsOpen.Text = "Det finns " + AmountOfCars + " lediga";
            GUI();
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
            lstRentedCars.Items.Clear();
            foreach (Car x in Cars)
            {
                switch (x.Rented)
                {
                    case (false):
                        lstAvalibleCars.Items.Add(x);
                        break;

                    case (true):
                        lstRentedCars.Items.Add(x);
                        break;

                    default:
                        break;
                }
            }
        }

        private void lstAvalibleCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRentCar.Enabled = true;
        }
    }
}

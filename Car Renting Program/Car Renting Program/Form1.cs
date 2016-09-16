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
        public string CustemerNumber = string.Empty;
        public string CustemerName = string.Empty;


        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            Cars.Add(new Car() { Maker = "Tyota", Color = "Röd", RegristerNumber = "AGD 582", Rented = false, Modle = "V38"});
            Cars.Add(new Car() { Maker = "Opel", Color = "Blå", RegristerNumber = "GSF 153", Rented = false, Modle = "Winter55"});
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
            Car a = (Car)lstAvalibleCars.SelectedItem;
            a.CustemerName = tbxCustmerName.Text;
            a.CustemerNumber = tbxCustemerNumber.Text;
            a.Rented = true;
            PrintCars();
            AmountOfCars--;
            lblNumberOfCarsOpen.Text = "Det finns " + AmountOfCars + " lediga bilar";
            GUI();
            pnlThankYouRented.Visible = true;
            lblThankYouRent.Text = "Tack för att du hyrde en bil";
            tbxCustemerNumber.Clear();
            tbxCustmerName.Clear();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            Car b = (Car)lstRentedCars.SelectedItem;
            b.Rented = false;
            PrintCars();
            AmountOfCars++;
            lblNumberOfCarsOpen.Text = "Det finns " + AmountOfCars + " lediga bilar";
            GUI();
            pnlThankYouReturn.Visible = true;
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
            lblNumberOfCarsOpen.Text = "Det finns " + AmountOfCars + " lediga bilar";
            GUI();
        }


        
        public void GUI()
        {
            pnlAddCar.Visible = false;
            pnlRentCar.Visible = false;
            pnlRentedCars.Visible = false;
            pnlThankYouReturn.Visible = false;
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
            Car a = (Car)lstAvalibleCars.SelectedItem;
            MessageBox.Show(" Model: " + a.Modle + "\r Skapare: " + a.Maker + "\r Färg: " + a.Color + "\r Regristerings numer: " + a.RegristerNumber);
            btnRentCar.Enabled = true;
        }

        private void lstRentedCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car b = (Car)lstRentedCars.SelectedItem;
            MessageBox.Show(" Model: " + b.Modle + "\r Skapare: " + b.Maker + "\r Färg: " + b.Color + "\r Regristerings numer: " +
                b.RegristerNumber + "\r \r Bilen är hyrd av: " + b.CustemerName + "\r Deras nummer är: " + b.CustemerNumber);
            btnReturnCar.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_Banking
{
    public partial class Form1 : Form
    {
        private bool isCustomer = true;


        System.Collections.ArrayList customers;

        public Form1()
        {
            InitializeComponent();

            customers = new System.Collections.ArrayList();
        }





        private void rbtnCus_CheckedChanged(object sender, EventArgs e)
        {
            isCustomer = true;
        }

        private void rbtnEmp_CheckedChanged(object sender, EventArgs e)
        {
            isCustomer = false;
        }




        private void btnCustAddCust_Click(object sender, EventArgs e)
        {
            if (controlSum(int.Parse(tbxCusStartCapital.Text)))
            {
                addCustomer(tbxCusFName.Text, tbxCusLName.Text, int.Parse(tbxCusStartCapital.Text));
            }
            else
            {
                MessageBox.Show("För lite pengar. Minimum är 500 SEK.");
            }
        }



        private bool controlSum(int sum)
        {
            if (sum >= 500)
                return true;
            else
                return false;
        }



        private void addCustomer(string fName, string lName, int startCapital)
        {
            customers.Add(new Customer(fName, lName, startCapital));
        }

    }
}

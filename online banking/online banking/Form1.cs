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
            displayContentInListBox(lbxCustomers, customers);
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCustomers.SelectedIndex != -1)
            {
                Customer c = (Customer)lbxCustomers.SelectedItem;
                displayContentInListBox(lbxAccounts, c.accounts);
            }
        }

        private void lbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAccounts.SelectedIndex != -1)
            {
                Account acc = (Account)lbxAccounts.SelectedItem;
                tbxMoney.Text = acc.getMoney().ToString();
            }
        }


        private void displayContentInListBox(ListBox lbox, System.Collections.ArrayList aList)
        {
            lbox.Items.Clear(); 
            foreach (var obj in aList)
            {
                lbox.Items.Add(obj); 
            }
        }
    }
}

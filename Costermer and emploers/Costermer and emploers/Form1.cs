using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costermer_and_emploers
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CostemerAndEmployee = new System.Collections.ArrayList();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string Firstname = tbxfirstName.Text;
            string LastName = tbxLastName.Text;

            if (RbtCostemer.Checked)
            {
                CostemerAndEmployee.Add(new Costemer() { CostemerFirstname = tbxLastName.Text, CostemerLastname = tbxfirstName.Text });
            }
            else
            {
                CostemerAndEmployee.Add(new Employee() { EmployeeFirstname = tbxLastName.Text, Employeelastname = tbxfirstName.Text });
            }

            AddCostemersAndEmployee();
        }

        public void AddCostemersAndEmployee()
        {
            foreach (var xxx in CostemerAndEmployee)
            {
                switch (xxx.GetType().Name)
                {
                    case "Costemer":
                        LbxCostemer.Items.Add("Customer:" + xxx);

                        break;

                    case "Employee":
                        LbxEmploee.Items.Add("Employee:" + xxx);
                        break;

                    default:
                        break;
                }
            }

        }
    }
}

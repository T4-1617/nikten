using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_regrister_Program
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Persons;
        bool[] CustemerID = new bool[100];
        public int AmountOfEmplooyees = 0;

        public Form1()
        {
            InitializeComponent();

            Persons = new System.Collections.ArrayList();

            comboBox1.Items.Add("Custemer");
            comboBox1.Items.Add("Emplooye");
            comboBox1.Items.Add("Deliverer");

            GUI();

            for (int i = 0; i < 100; i++)
            {
                CustemerID[i] = false;
            }
        }

        public void PrintList()
        {
            listBox1.Items.Clear();
            foreach (var x in Persons)
            {
                if (x is Costemer)
                    listBox1.Items.Add(x);
            }
            foreach (var z in Persons)
            {
                if (z is Emplooye)
                    listBox1.Items.Add(z);
            }
            foreach (var y in Persons)
            {
                if (y is Deliverer)
                    listBox1.Items.Add(y);
            }
        }

        public void GUI()
        {
            pnlCustemer.Visible = false;
            pnlEmplooye.Visible = false;
            pnlDeliverer.Visible = false;
            pnlInfo.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
            switch ((string)comboBox1.SelectedItem)
            {
                case ("Custemer"):
                    pnlCustemer.Visible = true;
                    break;

                case ("Emplooye"):
                    pnlEmplooye.Visible = true;
                    break;

                case ("Deliverer"):
                    pnlDeliverer.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI();
        }

        private void btnCustemerAdd_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                int randomID = r.Next(0, 101);
                if (CustemerID[randomID] == false)
                {
                    Persons.Add(new Costemer()
                    {
                        FirstName = tbxCustemerFirstName.Text,
                        LastName = tbxCustemerLastName.Text,
                        Telefone = tbxCustemerPhoneNumber.Text,
                        CustemerID = randomID
                    });
                    CustemerID[randomID] = true;
                }
                else
                {
                    i--;
                }
            }

            tbxCustemerFirstName.Text = string.Empty;
            tbxCustemerLastName.Text = string.Empty;
            tbxCustemerPhoneNumber.Text = string.Empty;

            PrintList();
            GUI();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlInfo.Visible = true;

            lblfirstName.Visible = false;
            lblInfoCustemerId.Visible = false;
            lblInfoEmplooyeID.Visible = false;
            lblLastName.Visible = false;
            lblInfoEmplooyePay.Visible = false;
            lblCountingPersons.Visible = false;
            lblInfoCompany.Visible = false;

            tbxInfoEmplooyeID.Visible = false;
            tbxInfoFirstName.Visible = false;
            tbxInfoID.Visible = false;
            tbxInfoLastName.Visible = false;
            tbxInfoNumber.Visible = false;
            tbxInfoConstatPerson.Visible = false;
            tbxInfoCompany.Visible = false;
            tbxInfoPay.Visible = false;

            Person a = (Person)listBox1.SelectedItem;
            if (a is Costemer)
            {
                lblfirstName.Visible = true;
                lblLastName.Visible = true;
                lblInfoCustemerId.Visible = true;

                tbxInfoFirstName.Visible = true;
                tbxInfoID.Visible = true;
                tbxInfoLastName.Visible = true;
                tbxInfoNumber.Visible = true;

                Costemer b = (Costemer)listBox1.SelectedItem;
                tbxInfoFirstName.Text = b.FirstName;
                tbxInfoLastName.Text = b.LastName;
                tbxInfoID.Text = b.CustemerID.ToString();
                tbxInfoNumber.Text = b.Telefone;
            }
            else if (a is Emplooye)
            {
                lblfirstName.Visible = true;
                lblLastName.Visible = true;
                lblInfoEmplooyeID.Visible = true;
                lblInfoEmplooyePay.Visible = true;

                tbxInfoFirstName.Visible = true;
                tbxInfoEmplooyeID.Visible = true;
                tbxInfoLastName.Visible = true;
                tbxInfoNumber.Visible = true;
                tbxInfoPay.Visible = true;

                Emplooye b = (Emplooye)listBox1.SelectedItem;
                tbxInfoFirstName.Text = b.FirstName;
                tbxInfoLastName.Text = b.LastName;
                tbxInfoEmplooyeID.Text = b.EmplooyeID.ToString();
                tbxInfoNumber.Text = b.Telefone;
                tbxInfoPay.Text = b.Pay;
            }
            else if (a is Deliverer)
            {
                lblCountingPersons.Visible = true;
                lblInfoCompany.Visible = true;
                lblPhoneNumber.Visible = true;

                tbxInfoConstatPerson.Visible = true;
                tbxInfoCompany.Visible = true;
                tbxInfoNumber.Visible = true;

                Deliverer b = (Deliverer)listBox1.SelectedItem;
                tbxInfoConstatPerson.Text = b.ToString();
                tbxInfoCompany.Text = b.Company;
                tbxInfoNumber.Text = b.Telefone;
            }
        }

        private void btnEmplooyeAdd_Click(object sender, EventArgs e)
        {
            Persons.Add(new Emplooye()
            {
                FirstName = tbxEmplooyeFirstName.Text,
                LastName = tbxEmplooyeLastName.Text,
                EmplooyeID = AmountOfEmplooyees,
                Pay = tbxEmplooyePay.Text,
                Telefone = tbxEmplooyePhoneNumber.Text
            });

            tbxEmplooyeFirstName.Text = string.Empty;
            tbxEmplooyeLastName.Text = string.Empty;
            tbxEmplooyePay.Text = string.Empty;
            tbxEmplooyePhoneNumber.Text = string.Empty;

            PrintList();
            GUI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string FullName = TbxDelivererConstactPerson.Text;
            int LettersInFullName = FullName.Length;
            int LettersInFirstName = 0;
            string FirstNameTemp = string.Empty;
            string LastNameTemp = string.Empty;


            foreach (int item in FullName)
            {
                if (item != ' ')
                    LettersInFirstName++;
            }

            for (int i = 0; i < LettersInFirstName; i++)
            {
                FirstNameTemp += FullName[i];
            }

            for (int i = LettersInFirstName + 1; i < LettersInFullName; i++)
            {
                LastNameTemp += FullName[i];
            }

            Persons.Add(new Deliverer() { FirstName = FirstNameTemp, LastName = LastNameTemp, Company = tbxDelivererCompany.Text, Telefone = tbxDelivererPhoneNumber.Text });

            tbxDelivererCompany.Text = string.Empty;
            TbxDelivererConstactPerson.Text = string.Empty;
            tbxDelivererPhoneNumber.Text = string.Empty;

            PrintList();
            GUI();
        }

        private void btnInfoSave_Click(object sender, EventArgs e)
        {
            Person a = (Person)listBox1.SelectedItem;
            if (a is Costemer)
            {
                Costemer b = (Costemer)listBox1.SelectedItem;
                b.FirstName = tbxInfoFirstName.Text;
                b.LastName = tbxInfoLastName.Text;
                b.Telefone = tbxInfoNumber.Text;
            }
            else if (a is Emplooye)
            {
                Emplooye b = (Emplooye)listBox1.SelectedItem;
                b.FirstName = tbxInfoFirstName.Text;
                b.LastName = tbxInfoLastName.Text;
                b.Pay = tbxInfoPay.Text;
                b.Telefone = tbxInfoNumber.Text;
            }
            else if (a is Deliverer)
            {
                Deliverer b = (Deliverer)listBox1.SelectedItem;
                b.Telefone = tbxInfoNumber.Text;
                b.Company = tbxInfoCompany.Text;

                string FullName = tbxInfoConstatPerson.Text;
                int LettersInFullName = FullName.Length;
                int LettersInFirstName = 0;
                string FirstNameTemp = string.Empty;
                string LastNameTemp = string.Empty;

                foreach (int item in FullName)
                {
                    if (item != ' ')
                        LettersInFirstName++;
                }

                for (int i = 0; i < LettersInFirstName; i++)
                {
                    FirstNameTemp += FullName[i];
                }

                for (int i = LettersInFirstName + 1; i < LettersInFullName; i++)
                {
                    LastNameTemp += FullName[i];
                }

                b.FirstName = FirstNameTemp;
                b.LastName = LastNameTemp;
            }

            PrintList();
            GUI();
        }

        private void btnEmplooyCancel_Click(object sender, EventArgs e)
        {
            GUI();
        }

        private void btnDelivererCancel_Click(object sender, EventArgs e)
        {
            GUI();
        }

        private void btnInfoCancel_Click(object sender, EventArgs e)
        {
            GUI();
        }
    }
}

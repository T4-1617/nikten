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
            pnlInfoCostemer.Visible = false;
            pnlInfoDeliverer.Visible = false;
            pnlInfoEmplooye.Visible = false;
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void pnlInfoEmplooye_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objekt_uppgift
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCostemer = new System.Collections.ArrayList();
        public int Costermer_amount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbxAdd_Click(object sender, EventArgs e)
        {
            int Random_ID = 0;
            Boolean Number_taken = false;
            Costermer_amount++;
            Costumer c = new Costumer();


            while (Number_taken == false)
            {
                Random r = new Random();
                Random_ID = r.Next(100, 201);

                Number_taken = true;

                foreach (Costumer d in MyCostemer)
                {
                    if (Random_ID == d.idnumer)
                    {
                        MessageBox.Show("Generated new number");
                        Number_taken = false;
                    }
                }
            }

            c.Firstname = tbxfirstname.Text;
            c.Lastname = tbxLastname.Text;
            c.idnumer = Random_ID;
            c.Archive = true;

            MyCostemer.Add(c);

            listBox1.Items.Add(c.Fullname());
            lblResult.Text = "Du har " + Costermer_amount + " kunder";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            Costumer a = new Costumer();
            a = (Costumer)MyCostemer[index];
            MessageBox.Show(String.Format("{0}, {1}, {2}", a.Fullname(), a.idnumer, a.Archive));
        }
    }
}

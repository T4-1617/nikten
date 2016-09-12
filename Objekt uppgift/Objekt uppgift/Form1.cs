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
        public int Costermer_number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tbxAdd_Click(object sender, EventArgs e)
        { 
            Costermer_number++;
            Costumer c = new Costumer();
            c.Firstname = tbxfirstname.Text;
            c.Lastname = tbxLastname.Text;

            listBox1.Items.Add(c.Fullname());

            Random r = new Random();
            int Random_ID = r.Next(100 , 201);

            lblResult.Text = "Du har " + Costermer_number + " kunder";
        }

        public class Costumer
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int idnumer { get; set; }
            public Boolean Archive { get; set; }

            public string Fullname()
            {
                return string.Format("{0} {1}", Firstname, Lastname);
            }
        }
    }
}

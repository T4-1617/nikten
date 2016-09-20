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
        public Form1()
        {
            InitializeComponent();

            Persons = new System.Collections.ArrayList();

            comboBox1.Items.Add("Costermer");
            comboBox1.Items.Add("Emplooye");
            comboBox1.Items.Add("Deliverer");

            GUI();
        }

        public void GUI()
        {
            pnlCostemer.Visible = false;
            pnlDeliverer.Visible = false;
            pnlEmplooye.Visible = false;
            pnlInfoCostemer.Visible = false;
            pnlInfoDeliverer.Visible = false;
            pnlInfoEmplooye.Visible = false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String förnamn = förnamnBox.Text;
            String efternamn = efternamBox.Text;
            namePlate.Text = "Hej, " + förnamn + " " + efternamn + "!";
            allaNamn.Text += förnamn + " " + efternamn + "\r\n";
        }
    }
}

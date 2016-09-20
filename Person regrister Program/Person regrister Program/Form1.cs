﻿using System;
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
            foreach (Costemer x in Persons)
            {
                listBox1.Items.Add(x);
            }
        }

        public void GUI()
        {
            pnlCustemer.Visible = false;
            pnlDeliverer.Visible = false;
            pnlEmplooye.Visible = false;
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
            Costemer a = new Costemer();
            a.FirstName = tbxCustemerFirstName.Text;
            a.LastName = tbxCustemerLastName.Text;
            a.Telefone = tbxCustemerPhoneNumber.Text;

            Random r = new Random();
            for (int i = 0; i < 1; i++)
            {
                int randomID = r.Next(0, 101);
                if (CustemerID[randomID] == false)
                {
                    a.CustemerID = randomID;
                    CustemerID[randomID] = true;
                }
                else
                {
                    i--;
                }
            }
            Persons.Add(a);
            PrintList();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

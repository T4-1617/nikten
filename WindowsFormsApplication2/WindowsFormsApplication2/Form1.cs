using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addBtn.Text = "+";
            MinusBtn.Text = "-";
            divideBtn.Text = "/";
            multiplyBtn.Text = "*";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int firstInt;
            int secondInt;
            int awnser;
            string first = firstTbx.Text;
            string second = secondTbx.Text;
            string tell = "";
            int.TryParse(first, out firstInt);
            int.TryParse(second, out secondInt);

            awnser = firstInt + secondInt;
            tell = first + " + " + second + " = " + awnser;

            AwnserList.Items.Add(tell + "\r\n");
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            int firstInt;
            int secondInt;
            int awnser;
            string first = firstTbx.Text;
            string second = secondTbx.Text;
            string tell = "";
            int.TryParse(first, out firstInt);
            int.TryParse(second, out secondInt);

            awnser = firstInt - secondInt;
            tell = first + " - " + second + " = " + awnser;

            AwnserList.Items.Add(tell + "\r\n");
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            int firstInt;
            int secondInt;
            int awnser;
            string first = firstTbx.Text;
            string second = secondTbx.Text;
            string tell = "";
            int.TryParse(first, out firstInt);
            int.TryParse(second, out secondInt);

            awnser = firstInt / secondInt;
            tell = first + " / " + second + " = " + awnser;

            AwnserList.Items.Add(tell + "\r\n");
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            int firstInt;
            int secondInt;
            int awnser;
            string first = firstTbx.Text;
            string second = secondTbx.Text;
            string tell = "";
            int.TryParse(first, out firstInt);
            int.TryParse(second, out secondInt);

            awnser = firstInt * secondInt;
            tell = first + " * " + second + " = " + awnser;

            AwnserList.Items.Add(tell + "\r\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil_register_program
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCar = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();

            Car c1 = new Car();

            c1.Car_Maker = "Tyota";
            c1.Gas_type = "El";
            c1.RegristerNumber = "ACU 472";

            MyCar.Add(c1);
            List_of_cars.Items.Add(c1.Car_name());


            Car c2 = new Car();

            c2.Car_Maker = "Opel";
            c2.Gas_type = "Bensin";
            c2.RegristerNumber = "KLW 671";

            MyCar.Add(c2);
            List_of_cars.Items.Add(c2.Car_name());

            Car c3 = new Car();
            c3.Car_Maker = "Volvo";
            c3.Gas_type = "Hybrid";
            c3.RegristerNumber = "KRZ 892";

            MyCar.Add(c3);
            List_of_cars.Items.Add(c3.Car_name());

            Car c4 = new Car();
            c4.Car_Maker = "Volkswagen";
            c4.Gas_type = "Disel";
            c4.RegristerNumber = "THA 935";

            MyCar.Add(c4);
            List_of_cars.Items.Add(c4.Car_name());

            Car c5 = new Car();
            c5.Car_Maker = "Volvo";
            c5.Gas_type = "El";
            c5.RegristerNumber = "JLE 923";

            MyCar.Add(c5);
            List_of_cars.Items.Add(c5.Car_name());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void List_of_cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = List_of_cars.SelectedIndex;


            if (index == -1)
                index = 1;
            /*
             * For unknow resons, the code will change index to -1 when the text is edited and crash.
             * This fixes it. 
             */


            Car a = (Car)MyCar[index];
            tbxCarMark.Text = a.Car_Maker;
            tbxGas_type.Text = a.Gas_type;
            tbxRegristerNumber.Text = a.RegristerNumber;
            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            panel1.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            tbxRegristerNumber.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = List_of_cars.SelectedIndex;
            Car b = (Car)MyCar[index];
            b.Car_Maker = tbxCarMark.Text;
            b.Gas_type = tbxGas_type.Text;

            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            panel1.Enabled = false;

            List_of_cars.Items[index] = b.Car_name();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int index = List_of_cars.SelectedIndex;

            Car a = (Car)MyCar[index];
            tbxCarMark.Text = a.Car_Maker;
            tbxGas_type.Text = a.Gas_type;
            tbxRegristerNumber.Text = a.RegristerNumber;

            btnEdit.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            panel1.Enabled = false;
        }
    }
}

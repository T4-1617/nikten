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

            Car c = new Car();

            c.Car_Maker = "Tyota";
            c.Gas_type = "El";
            c.RegristerNumber = "ACU 472";

            MyCar.Add(c);
            List_of_cars.Items.Add(c.Car_name());

            c.Car_Maker = "Opel";
            c.Gas_type = "Bensin";
            c.RegristerNumber = "KLW 671";

            MyCar.Add(c);
            List_of_cars.Items.Add(c.Car_name());

            c.Car_Maker = "Volvo";
            c.Gas_type = "Hybrid";
            c.RegristerNumber = "KRZ 892";

            MyCar.Add(c);
            List_of_cars.Items.Add(c.Car_name());

            c.Car_Maker = "Volkswagen";
            c.Gas_type = "Disel";
            c.RegristerNumber = "THA 935";

            MyCar.Add(c);
            List_of_cars.Items.Add(c.Car_name());

            c.Car_Maker = "Volvo";
            c.Gas_type = "El";
            c.RegristerNumber = "JLE 923";

            MyCar.Add(c);
            List_of_cars.Items.Add(c.Car_name());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_Inheritance_Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Car("Ford", "Mustange", 2014, 12500, 85, 2, false);
            vehicles[1] = new ElectricCar("Tesla", "Model 3", 2018, 85, 4, false, 265);
            vehicles[2] = new Car();
            vehicles[3] = new Vehicle();
            vehicles[4] = new ElectricCar();

            for (int i = 0; i < vehicles.Length; i++)
            {
                OutputListBox.Items.Add(vehicles[i].Make + "," + vehicles[i].Model);
            }
        }
    }
}

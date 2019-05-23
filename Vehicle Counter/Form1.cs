using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Counter
{
    public partial class VehicleCounter : Form
    {
        public static string car_char = "0";
        public static string minibus_char = "1";
        public static string twoaxes_char = "2";
        public static string threeaxes_char = "3";
        public static string fouraxes_char = "4";
        public static string bus_char = "5";
        public static string bike_char = "6";

        protected int car_n = 0;
        protected int minibus_n = 0;
        protected int twoaxes_n = 0;
        protected int threeaxes_n = 0;
        protected int fouraxes_n = 0;
        protected int bus_n = 0;
        protected int bike_n = 0;


        public VehicleCounter()
        {
            InitializeComponent();
        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals(car_char))
            {
                car_n++;
                car.Text = car_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(minibus_char))
            {
                minibus_n++;
                minibus.Text = minibus_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(twoaxes_char))
            {
                twoaxes_n++;
                twoaxes.Text = twoaxes_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(threeaxes_char))
            {
                threeaxes_n++;
                threeaxes.Text = threeaxes_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(fouraxes_char))
            {
                fouraxes_n++;
                fouraxes.Text = fouraxes_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(bus_char))
            {
                bus_n++;
                bus.Text = bus_n.ToString();
            }

            if (e.KeyChar.ToString().Equals(bike_char))
            {
                bike_n++;
                bike.Text = bike_n.ToString();
            }
            
        }

        private void car_button_Click(object sender, EventArgs e)
        {
            
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            car_n = 0;
            minibus_n = 0;
            twoaxes_n = 0;
            threeaxes_n = 0;
            fouraxes_n = 0;
            bus_n = 0;
            bike_n = 0;

            car.Text = "0";
            minibus.Text = "0";
            twoaxes.Text = "0";
            threeaxes.Text = "0";
            fouraxes.Text = "0";
            bus.Text = "0";
            bike.Text = "0";

        }
    }
}

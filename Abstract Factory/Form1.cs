using Abstract_Factory._1_Interface;
using Abstract_Factory._3_Factory;
using Abstract_Factory._4_SubClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Abstract Factory pattern demo");
            ACarFactory carFactory = null;
            IEconomy economy = null;
            IPremium premium = null;

            //Maruti 
            carFactory = new MarutiFactory();
            economy = carFactory.GetEconomy();
            premium = carFactory.GetPremium();
            listBox1.Items.Add(
                string.Format(
                    "Normal car is: " + economy.ShowEconomy() + "\nPremium Car is: " + premium.ShowPremium()
                    )
                );
        }
    }
}

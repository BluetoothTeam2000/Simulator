using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator
{
    public partial class Simulator : Form
    {
        public Simulator()
        {
            InitializeComponent();
        }

        private void buttonSYM_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            if(checkTemp.Checked)
            {
                labelResult.Text = random.Next(-20, 70).ToString() + "°C";
            }

            if(checkWilg.Checked)
            {
                labelResult.Text = random.Next(0, 100).ToString() + "%";
            }

            if(checkCis.Checked)
            {
                labelResult.Text = random.Next(0, 100000).ToString() + "Pa";
            }

            if(checkNAPB.Checked)
            {
                labelResult.Text = random.Next(0, 10).ToString() + "V";
            }

            if (checkNAPSOL.Checked)
            {
                labelResult.Text = random.Next(0, 100).ToString() + "V";
            }

            if (checkNAPW.Checked)
            {
                labelResult.Text = random.Next(0, 50).ToString() + "V";
            }

            if (checkNATB.Checked)
            {
                labelResult.Text = random.Next(0, 5).ToString() + "A";
            }

            if (checkNATSOL.Checked)
            {
                labelResult.Text = random.Next(0, 30).ToString() + "A";
            }

            if (checkNATW.Checked)
            {
                labelResult.Text = random.Next(0, 15).ToString() + "A";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu openMenu = new Menu();
            openMenu.Show();
            Close();
        }
    }
}

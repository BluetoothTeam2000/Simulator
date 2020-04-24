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
    public partial class Sim : Form
    {
        public Sim()
        {
            InitializeComponent();
        }

        private void buttonSYM_Click(object sender, EventArgs e)
        {
            listViewResult.Columns.Clear();

            if(checkTemp.Checked == true)
            {
                listViewResult.Columns.Add("Temperature");
            }

            if(checkWilg.Checked == true)
            {
                listViewResult.Columns.Add("Humidity");
            }

            if(checkCis.Checked == true)
            {
                listViewResult.Columns.Add("Pressure");
            }

            if(checkNAPB.Checked == true)
            {
                listViewResult.Columns.Add("Battery Voltage");
            }

            if (checkNAPSOL.Checked == true)
            {
                listViewResult.Columns.Add("Solar Panel Voltage");
            }

            if (checkNAPW.Checked == true)
            {
                listViewResult.Columns.Add("Node Voltage");
            }

            if (checkNATB.Checked == true)
            {
                listViewResult.Columns.Add("Battery Current");
            }

            if (checkNATSOL.Checked == true)
            {
                listViewResult.Columns.Add("Solar Panel Current");
            }

            if (checkNATW.Checked == true)
            {
                listViewResult.Columns.Add("Node Current");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu openMenu = new Menu();
            openMenu.Show();
            this.Close();
        }
    }
}

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
        Timer timer = new Timer();
        int id = 1;
        double temperature, humidity, pressure, battery_voltage, solar_panel_voltage, node_voltage, battery_current, solar_panel_current, node_current;

        public Simulator()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listViewResult.Columns.Clear();
            listViewResult.Items.Clear();
            listViewResult.Columns.Add("ID");
            ListViewItem item = new ListViewItem(id.ToString());

            buttonStart.Enabled = false;
            foreach (Control c in Controls)
            {
                if(c is CheckBox)
                {
                    c.Enabled = false;
                }
            }

            if (checkTemp.Checked)
            {
                listViewResult.Columns.Add("Temperature", 100);
                temperature = Math.Round(randomDouble(-30, 50), 3);
                item.SubItems.Add(temperature.ToString() + " °C");
            }

            if(checkWilg.Checked)
            {
                listViewResult.Columns.Add("Humidity", 100);
                humidity = Math.Round(randomDouble(0, 100));
                item.SubItems.Add(humidity.ToString() + "%");
            }

            if(checkCis.Checked)
            {
                listViewResult.Columns.Add("Pressure", 100);
                pressure = Math.Round(randomDouble(980, 1020));
                item.SubItems.Add(pressure.ToString() + " hPa");
            }

            if(checkNAPB.Checked)
            {
                listViewResult.Columns.Add("Battery Voltage", 100);
                battery_voltage = Math.Round(randomDouble(2.5, 4.8));
                item.SubItems.Add(battery_voltage.ToString() + " V");
            }

            if (checkNAPSOL.Checked)
            {
                listViewResult.Columns.Add("Solar Panel Voltage", 100);
                solar_panel_voltage = Math.Round(randomDouble(28, 32));
                item.SubItems.Add(solar_panel_voltage.ToString() + " V");
            }

            if (checkNAPW.Checked)
            {
                listViewResult.Columns.Add("Node Voltage", 100);
                node_voltage = Math.Round(randomDouble(28, 32));
                item.SubItems.Add(node_voltage.ToString() + " V");
            }

            if (checkNATB.Checked)
            {
                listViewResult.Columns.Add("Battery Current", 100);
                battery_current = Math.Round(randomDouble(6.0, 9.0));
                item.SubItems.Add(battery_current.ToString() + " A");
            }

            if (checkNATSOL.Checked)
            {
                listViewResult.Columns.Add("Solar Panel Current", 100);
                solar_panel_current = Math.Round(randomDouble(6, 9));
                item.SubItems.Add(solar_panel_current.ToString() + " A");
            }

            if (checkNATW.Checked)
            {
                listViewResult.Columns.Add("Node Current", 100);
                node_current = Math.Round(randomDouble(6, 9));
                item.SubItems.Add(node_current.ToString() + " A");
            }
            
            listViewResult.Items.Insert(0, item);
            timer.Interval = 5000;
            timer.Tick += new EventHandler(this.t_Tick);
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            id = 1;
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                    c.Enabled = true;
            }
            buttonStart.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu openMenu = new Menu();
            openMenu.Show();
            Close();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            id++;
            ListViewItem item = new ListViewItem(id.ToString());

            if (checkTemp.Checked)
            {
                double temporary = temperature + Math.Round(randomDouble(-1, 1), 3);
                while (temporary < -30 || temporary > 50)
                {
                    temporary = temperature + Math.Round(randomDouble(-1, 1), 3);
                }
                temperature = temporary;
                item.SubItems.Add(temperature.ToString() + " °C");
            }

            if (checkWilg.Checked)
            {
                double temporary = humidity + Math.Round(randomDouble(-1, 1), 3);
                while (temporary < 0 || temporary > 100)
                {
                    temporary = humidity + Math.Round(randomDouble(-1, 1), 3);
                }
                humidity = temporary;
                item.SubItems.Add(humidity.ToString() + "%");
            }

            if (checkCis.Checked)
            {
                double temporary = pressure + Math.Round(randomDouble(-1, 1), 3);
                while (temporary < 980 || temporary > 1020)
                {
                    temporary = pressure + Math.Round(randomDouble(-1, 1), 3);
                }
                pressure = temporary;
                item.SubItems.Add(pressure.ToString() + " hPa");
            }

            if (checkNAPB.Checked)
            {
                double temporary = battery_voltage + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 2.5 || temporary > 4.8)
                {
                    temporary = battery_voltage + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                battery_voltage = temporary;
                item.SubItems.Add(battery_voltage.ToString() + " V");
            }

            if (checkNAPSOL.Checked)
            {
                double temporary = solar_panel_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                while (temporary < 28 || temporary > 32)
                {
                    temporary = solar_panel_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                }
                solar_panel_voltage = temporary;
                item.SubItems.Add(solar_panel_voltage.ToString() + " V");
            }

            if (checkNAPW.Checked)
            {
                double temporary = node_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                while (temporary < 28 || temporary > 32)
                {
                    temporary = node_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                }
                node_voltage = temporary;
                item.SubItems.Add(node_voltage.ToString() + " V");
            }

            if (checkNATB.Checked)
            {
                double temporary = battery_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 6 || temporary > 9)
                {
                    temporary = battery_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                battery_current = temporary;
                item.SubItems.Add(battery_current.ToString() + " A");
            }

            if (checkNATSOL.Checked)
            {
                double temporary = solar_panel_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 6 || temporary > 9)
                {
                    temporary = solar_panel_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                solar_panel_current = temporary;
                item.SubItems.Add(solar_panel_current.ToString() + " A");
            }

            if (checkNATW.Checked)
            {
                double temporary = node_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 6 || temporary > 9)
                {
                    temporary = node_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                node_current = temporary;
                item.SubItems.Add(node_current.ToString() + " A");
            }
            listViewResult.Items.Insert(0, item);
        }

        private double randomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}

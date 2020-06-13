using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using InTheHand.Net.Sockets;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using System.Net.Sockets;

namespace Simulator
{
    public partial class Simulator : Form
    {
        Timer timerTemp = new Timer();
        Timer timerHum = new Timer();
        Timer timerPress = new Timer();
        Timer timerEnergy = new Timer();

        double temperature, humidity, pressure, battery_voltage, solar_panel_voltage, node_voltage, battery_current, solar_panel_current, node_current;

        private static BluetoothEndPoint EP = new BluetoothEndPoint(BluetoothRadio.PrimaryRadio.LocalAddress, BluetoothService.BluetoothBase);
        private static BluetoothClient BC = new BluetoothClient(EP);
        private static NetworkStream stream = null;
        public static BluetoothDeviceInfo BTDevice = null;


        public Simulator()
        {
            InitializeComponent();
            comboBoxTemp.SelectedIndex = 0;
            comboBoxHum.SelectedIndex = 0;
            comboBoxPress.SelectedIndex = 0;
            comboBoxEnergy.SelectedIndex = 0;

            BC.BeginConnect(BTDevice.DeviceAddress, BluetoothService.SerialPort, new AsyncCallback(Connect), BTDevice);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());
            listViewTemp.Items.Clear();
            listViewHum.Items.Clear();
            listViewPress.Items.Clear();
            listViewEnergy.Items.Clear();

            listViewTemp.Columns.Clear();
            listViewHum.Columns.Clear();
            listViewPress.Columns.Clear();
            listViewEnergy.Columns.Clear();

            buttonStart.Enabled = false;
            foreach (Control c in Controls)
            {
                if (c is CheckBox || c is ComboBox)
                {
                    c.Enabled = false;
                }
            }

            if (checkTemp.Checked)
            {
                listViewTemp.Columns.Add("Timestamp", 110);
                listViewTemp.Columns.Add("Temperature", 75);
                temperature = Math.Round(randomDouble(-30, 50), 3);
                item.SubItems.Add(temperature.ToString() + " C");
                timerTemp.Interval = int.Parse(comboBoxTemp.Text) * 1000;
                timerTemp.Tick += new EventHandler(tempTick);
                timerTemp.Start();
            }

            if (checkWilg.Checked)
            {
                listViewHum.Columns.Add("Timestamp", 110);
                listViewHum.Columns.Add("Humidity", 70);
                humidity = Math.Round(randomDouble(0, 100), 3);
                item.SubItems.Add(humidity.ToString() + "%");
                timerHum.Interval = int.Parse(comboBoxHum.Text) * 1000;
                timerHum.Tick += new EventHandler(humTick);
                timerHum.Start();
            }

            if (checkCis.Checked)
            {
                listViewPress.Columns.Add("Timestamp", 110);
                listViewPress.Columns.Add("Pressure", 80);
                pressure = Math.Round(randomDouble(980, 1020), 3);
                item.SubItems.Add(pressure.ToString() + " hPa");
                timerPress.Interval = int.Parse(comboBoxPress.Text) * 1000;
                timerPress.Tick += new EventHandler(pressTick);
                timerPress.Start();
            }

            if (checkNAPB.Checked || checkNAPSOL.Checked || checkNAPW.Checked || checkNATB.Checked || checkNATSOL.Checked || checkNATW.Checked)
            {
                listViewEnergy.Columns.Add("Timestamp", 110);
            }

            if (checkNAPB.Checked)
            {
                listViewEnergy.Columns.Add("Battery Voltage", 85);
                battery_voltage = Math.Round(randomDouble(2.5, 4.8), 3);
                item.SubItems.Add(battery_voltage.ToString() + " V");
            }

            if (checkNAPSOL.Checked)
            {
                listViewEnergy.Columns.Add("Solar Panel Voltage", 110);
                solar_panel_voltage = Math.Round(randomDouble(50.1, 60.3), 3);
                item.SubItems.Add(solar_panel_voltage.ToString() + " V");
            }

            if (checkNAPW.Checked)
            {
                listViewEnergy.Columns.Add("Node Voltage", 80);
                node_voltage = Math.Round(randomDouble(28.4, 32.6), 3);
                item.SubItems.Add(node_voltage.ToString() + " V");
            }

            if (checkNATB.Checked)
            {
                listViewEnergy.Columns.Add("Battery Current", 85);
                battery_current = Math.Round(randomDouble(6.2, 9.8), 3);
                item.SubItems.Add(battery_current.ToString() + " A");
            }

            if (checkNATSOL.Checked)
            {
                listViewEnergy.Columns.Add("Solar Panel Current", 105);
                solar_panel_current = Math.Round(randomDouble(10.7, 15.9), 3);
                item.SubItems.Add(solar_panel_current.ToString() + " A");
            }

            if (checkNATW.Checked)
            {
                listViewEnergy.Columns.Add("Node Current", 75);
                node_current = Math.Round(randomDouble(8.5, 12.8), 3);
                item.SubItems.Add(node_current.ToString() + " A");
            }

            if (checkNAPB.Checked || checkNAPSOL.Checked || checkNAPW.Checked || checkNATB.Checked || checkNATSOL.Checked || checkNATW.Checked)
            {
                timerEnergy.Interval = int.Parse(comboBoxEnergy.Text) * 1000;
                timerEnergy.Tick += new EventHandler(energyTick);
                timerEnergy.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerTemp.Stop();
            timerHum.Stop();
            timerPress.Stop();
            timerEnergy.Stop();

            timerTemp.Tick -= new EventHandler(tempTick);
            timerHum.Tick -= new EventHandler(humTick);
            timerPress.Tick -= new EventHandler(pressTick);
            timerEnergy.Tick -= new EventHandler(energyTick);

            foreach (Control c in Controls)
            {
                if (c is CheckBox || c is ComboBox)
                    c.Enabled = true;
            }
            buttonStart.Enabled = true;

            List<ListView> lists = new List<ListView>
            {
                listViewTemp, listViewHum, listViewPress, listViewEnergy
            };

            foreach  (ListView l in lists)
            {
                if (l.Name.Equals("listViewEnergy"))
                {
                    List<HistoryData> historyBatteryV = new List<HistoryData>();
                    List<HistoryData> historySolarV = new List<HistoryData>();
                    List<HistoryData> historyNodeV = new List<HistoryData>();
                    List<HistoryData> historyBatteryC = new List<HistoryData>();
                    List<HistoryData> historySolarC = new List<HistoryData>();
                    List<HistoryData> historyNodeC = new List<HistoryData>();

                    foreach (ColumnHeader c in l.Columns)
                    {
                        foreach (ListViewItem item in l.Items)
                        {
                            if  (c.Text == "Battery Voltage")
                            {
                                string file = "battery_voltage.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string batteryV = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(batteryV);
                                    if (temp != null)
                                        historyBatteryV = temp;
                                }
                                int index = c.Index;
                                historyBatteryV.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historyBatteryV.ToArray());  ;
                                File.WriteAllText(path, json);
                            }
                            else if (c.Text == "Solar Panel Voltage")
                            {
                                string file = "solarpanel_voltage.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string solarV = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(solarV);
                                    if  (temp != null)
                                        historySolarV = temp;
                                }
                                int index = c.Index;
                                historySolarV.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historySolarV.ToArray()); ;
                                File.WriteAllText(path, json);
                            }
                            else if (c.Text == "Node Voltage")
                            {
                                string file = "node_voltage.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string nodeV = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(nodeV);
                                    if (temp != null)
                                        historyNodeV = temp;
                                }
                                int index = c.Index;
                                historyNodeV.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historyNodeV.ToArray()); ;
                                File.WriteAllText(path, json);
                            }
                            else if (c.Text == "Battery Current")
                            {
                                string file = "battery_current.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string batteryC = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(batteryC);
                                    if (temp != null)
                                        historyBatteryC = temp;
                                }
                                int index = c.Index;
                                historyBatteryC.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historyBatteryC.ToArray()); ;
                                File.WriteAllText(path, json);
                            }
                            else if (c.Text == "Solar Panel Current")
                            {
                                string file = "solarpanel_current.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string solarC = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(solarC);
                                    if (temp != null)
                                        historySolarC = temp;
                                }
                                int index = c.Index;
                                historySolarC.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historySolarC.ToArray()); ;
                                File.WriteAllText(path, json);
                            }
                            else if (c.Text == "Node Current")
                            {
                                string file = "node_current.json";
                                string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                                using (StreamReader r = new StreamReader(path))
                                {
                                    string nodeC = r.ReadToEnd();
                                    List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(nodeC);
                                    if (temp != null)
                                        historyNodeC = temp;
                                }
                                int index = c.Index;
                                historyNodeC.Add(new HistoryData()
                                {
                                    timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                                    data = item.SubItems[index].Text.ToString()
                                });
                                string json = JsonConvert.SerializeObject(historyNodeC.ToArray()); ;
                                File.WriteAllText(path, json);
                            }
                        }
                    }
                }
                else
                {
                    List<HistoryData> historyData = new List<HistoryData>();
                    string file = null;
                    switch (l.Name)
                    {
                        case "listViewTemp": file = "temperature.json"; break;
                        case "listViewHum": file = "humidity.json"; break;
                        case "listViewPress": file = "pressure.json"; break;
                    }
                    string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
                    using (StreamReader r = new StreamReader(path))
                    {
                        string nodeC = r.ReadToEnd();
                        List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(nodeC);
                        if (temp != null)
                            historyData = temp;
                    }
                    foreach (ListViewItem item in l.Items)
                    {
                        historyData.Add(new HistoryData()
                        {
                            timestamp = DateTime.Parse(item.SubItems[0].Text.ToString()),
                            data = item.SubItems[1].Text.ToString()
                        });

                    }
                    string json = JsonConvert.SerializeObject(historyData.ToArray());
                    File.WriteAllText(path, json);
                }

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu openMenu = new Menu();
            openMenu.Show();
            Close();
        }

        private void tempTick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());

            double temporary = temperature + Math.Round(randomDouble(-1, 1), 3);
            while (temporary < -30 || temporary > 50)
            {
                temporary = temperature + Math.Round(randomDouble(-1, 1), 3);
            }
            temperature = temporary;
            item.SubItems.Add(temperature.ToString() + " C");
            listViewTemp.Items.Insert(0, item);
        }

        private void humTick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());

            double temporary = humidity + Math.Round(randomDouble(-1, 1), 3);
            while (temporary < 0 || temporary > 100)
            {
                temporary = humidity + Math.Round(randomDouble(-1, 1), 3);
            }
            humidity = temporary;
            item.SubItems.Add(humidity.ToString() + "%");
            listViewHum.Items.Insert(0, item);
        }

        private void pressTick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());

            double temporary = pressure + Math.Round(randomDouble(-1, 1), 3);
            while (temporary < 980 || temporary > 1020)
            {
                temporary = pressure + Math.Round(randomDouble(-1, 1), 3);
            }
            pressure = temporary;
            item.SubItems.Add(pressure.ToString() + " hPa");
            listViewPress.Items.Insert(0, item);
        }

        private void energyTick(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(DateTime.Now.ToString());

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
                while (temporary < 50.1 || temporary > 60.3)
                {
                    temporary = solar_panel_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                }
                solar_panel_voltage = temporary;
                item.SubItems.Add(solar_panel_voltage.ToString() + " V");
            }

            if (checkNAPW.Checked)
            {
                double temporary = node_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                while (temporary < 28.4 || temporary > 32.6)
                {
                    temporary = node_voltage + Math.Round(randomDouble(-0.5, 0.5), 3);
                }
                node_voltage = temporary;
                item.SubItems.Add(node_voltage.ToString() + " V");
            }

            if (checkNATB.Checked)
            {
                double temporary = battery_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 6.2 || temporary > 9.8)
                {
                    temporary = battery_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                battery_current = temporary;
                item.SubItems.Add(battery_current.ToString() + " A");
            }

            if (checkNATSOL.Checked)
            {
                double temporary = solar_panel_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 10.7 || temporary > 15.9)
                {
                    temporary = solar_panel_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                solar_panel_current = temporary;
                item.SubItems.Add(solar_panel_current.ToString() + " A");
            }

            if (checkNATW.Checked)
            {
                double temporary = node_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                while (temporary < 8.5 || temporary > 12.8)
                {
                    temporary = node_current + Math.Round(randomDouble(-0.1, 0.1), 3);
                }
                node_current = temporary;
                item.SubItems.Add(node_current.ToString() + " A");
            }
            listViewEnergy.Items.Insert(0, item);
        }

        private double randomDouble(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        private static void Connect(IAsyncResult result)
        {
            if (result.IsCompleted)
            {
                Console.WriteLine(BC.Connected);
                stream = BC.GetStream();

                if (stream.CanRead)
                {
                    byte[] myReadBuffer = new byte[1024];
                    StringBuilder myCompleteMessage = new StringBuilder();
                    int numberOfBytesRead = 0;

                    do
                    {
                        numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

                        myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
                    }
                    while (stream.DataAvailable);

                    Console.WriteLine("You received the following message: " + myCompleteMessage);
                }
                else
                {
                    Console.WriteLine("Sorry. You cannot read from this NetworkStream.");
                }

                Console.ReadLine();
            }
        }
    }
}

using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using InTheHand.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net.Sockets;

namespace Simulator
{
    public partial class Menu : Form
    {
        BluetoothClient client;
        BluetoothDeviceInfo[] devices;
        static BluetoothDeviceInfo selectedDevice;
        static bool isPaired = false;
        BluetoothClient remoteDevice;
        NetworkStream stream;
        bool connection = true;

        public Menu()     {
            InitializeComponent();
            labelInfo.Text = "";
            Console.WriteLine("Paired: "+isPaired);
            Console.WriteLine(BluetoothRadio.PrimaryRadio.LocalAddress);
        }

        static EventHandler<BluetoothWin32AuthenticationEventArgs> authHandler = new EventHandler<BluetoothWin32AuthenticationEventArgs>(handleAuthRequests);
        BluetoothWin32Authentication authenticator = new BluetoothWin32Authentication(authHandler);

        private void btnPairSSP_Click_1(object sender, EventArgs e)
        {
            if (listBoxDevices.SelectedItem == null)
            {
                labelInfo.Text = "Choose device first!";
            }
            else
            {
                selectedDevice = devices[listBoxDevices.SelectedIndex];
                if (MessageBox.Show(String.Format("Would you like to attempt to pair with {0}?", selectedDevice.DeviceName), "Pair Device", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Task t = new Task(PairBluetoothTask);
                    t.Start();
                }
            }          
        }

        private void PairBluetoothTask()
        {
            this.Invoke((MethodInvoker)(() => selectedDevice = devices[listBoxDevices.SelectedIndex]));
            if(isPaired)
            {
                if(MessageBox.Show("Device is already paired! Do you want to unpair?", "Pairing...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BluetoothSecurity.RemoveDevice(selectedDevice.DeviceAddress);
                    isPaired = false;
                }
            }
            else
            {
                if (BluetoothSecurity.PairRequest(selectedDevice.DeviceAddress, "0000"))
                {
                    isPaired = true;
                    MessageBox.Show("We paired!");
                    //Simulator.BTDevice = new BluetoothDeviceInfo(selectedDevice.DeviceAddress);
                }
                else
                {
                    MessageBox.Show("Failed to pair!");
                }
            }
        }

        private static void handleAuthRequests(object sender, BluetoothWin32AuthenticationEventArgs e)
        {
            switch (e.AuthenticationMethod)
            {
                case BluetoothAuthenticationMethod.Legacy:
                    MessageBox.Show("Legacy Authentication");
                    break;

                case BluetoothAuthenticationMethod.OutOfBand:
                    MessageBox.Show("Out of Band Authentication");
                    break;

                case BluetoothAuthenticationMethod.NumericComparison:
                    if (e.JustWorksNumericComparison == true)
                    {
                        MessageBox.Show("Just Works Numeric Comparison");
                    }
                    else
                    {
                        MessageBox.Show("Show User Numeric Comparison");
                        if (MessageBox.Show(e.NumberOrPasskeyAsString, "Pair Device", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            e.Confirm = true;
                        }
                        else
                        {
                            e.Confirm = false;
                        }
                    }
                    break;

                case BluetoothAuthenticationMethod.PasskeyNotification:
                    MessageBox.Show("Passkey Notification");
                    break;

                case BluetoothAuthenticationMethod.Passkey:
                    MessageBox.Show("Passkey");
                    break;

                default:
                    MessageBox.Show("Event handled in some unknown way");
                    break;
            }
        }

        void Listen()
        {
            //BluetoothListener listener = new BluetoothListener(BluetoothAddress.Parse("38:BA:F8:28:32:9F"), BluetoothService.SerialPort);
            BluetoothListener listener = new BluetoothListener(BluetoothRadio.PrimaryRadio.LocalAddress, BluetoothService.SerialPort);
            listener.Start();
            Console.WriteLine("Listener dziala!");
            listener.BeginAcceptBluetoothClient(new AsyncCallback(AcceptConnection), listener);
        }

        void AcceptConnection(IAsyncResult result)
        {
            Console.WriteLine("AKCEPTOWANO CONNECTION!");
            if (result.IsCompleted)
            {
                remoteDevice = ((BluetoothListener)result.AsyncState).EndAcceptBluetoothClient(result);
                //remoteDevice.Connect(BluetoothAddress.Parse("94:21:97:60:07:C0"), BluetoothService.SerialPort);
                stream = remoteDevice.GetStream();

                if (stream.CanRead)
                {
                    byte[] myReadBuffer = new byte[1024];
                    StringBuilder myCompleteMessage = new StringBuilder();
                    int numberOfBytesRead = 0;

                    do
                    {
                        numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

                        //for (int i = 0; i < numberOfBytesRead; i++)
                        //  myCompleteMessage.AppendFormat("0x{0:X2} ", myReadBuffer);
                        myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));
                    }
                    while (stream.DataAvailable);
                    
                    Command command = JsonConvert.DeserializeObject<Command>(myCompleteMessage.ToString());
                    foreach(string temp in command.val)
                    {
                        Console.WriteLine(temp);
                    }

                    Console.WriteLine("You received the following message: " + myCompleteMessage);
                    sendFiles(command);
                }
                else
                {
                    Console.WriteLine("Sorry. You cannot read from this NetworkStream.");
                }

                Console.WriteLine("ZWYCIESTWO!");
            }            
        }

        private void sendFiles(Command command)
        {
            List<string> val = command.val;
            string file = val[1]+".json";
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\history_data\", file);
            DateTime timestampStart = DateTime.Parse(val[2]);
            DateTime timestampStop = DateTime.Parse(val[3]);
            using (StreamReader r = new StreamReader(path))
            {
                string content = r.ReadToEnd();
                List<HistoryData> temp = JsonConvert.DeserializeObject<List<HistoryData>>(content);
                if (temp != null)
                {
                    Response response = new Response();
                    response.command = "get response";
                    response.values = new List<HistoryData>();
                    foreach(HistoryData historyData in temp)
                    {
                        // DateTime timestampFile = DateTime.Parse(historyData.timestamp);
                        if (DateTime.Compare(timestampStart, historyData.timestamp) <= 0 && DateTime.Compare(timestampStop, historyData.timestamp) >= 0)
                        {                         
                            response.values.Add(historyData);
                        }
                    }
                    string json = JsonConvert.SerializeObject(response);

                    Console.WriteLine("Wynik "+json);

                    byte[] bytes = Encoding.ASCII.GetBytes(json);

                    //using (var bluetoothClient = new BluetoothClient())
                   // {
                        try
                        {

                            //var endpoint = new BluetoothEndPoint(BluetoothAddress.Parse("38:BA:F8:28:32:9F"), new Guid("{646171EA-EA18-4CCF-8D7A-C57D46991775}"));
                           // bluetoothClient.Connect(BluetoothAddress.Parse("38:BA:F8:28:32:9F"), new Guid("{646171EA-EA18-4CCF-8D7A-C57D46991775}"));

                            //var bluetoothStream = bluetoothClient.GetStream();

                            if (remoteDevice.Connected && stream != null)
                            {
                                stream.Write(bytes, 0, bytes.Length);
                                stream.Flush();
                                stream.Close();
                                remoteDevice.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            // TODO: handle exception
                        }
                    //}
                }                  
            }            
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            connection = false;
            Simulator openSimulator = new Simulator();
            openSimulator.Show();
            Hide();           
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            if(isPaired)
            {
                connection = false;
                BluetoothSecurity.RemoveDevice(selectedDevice.DeviceAddress);
            }
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {         
            client = new BluetoothClient(); 
            devices = client.DiscoverDevices();
            listBoxDevices.Items.Clear();
            if (devices.Length > 0)
            {
                labelInfo.Text = "Scan successful";
                foreach (var device in devices)
                {
                    listBoxDevices.Items.Add(device.DeviceName);
                }
            }
            else
            {
                labelInfo.Text = "Unable to detect any bluetooth devices";
            }

            Listen();
        }
    }
}
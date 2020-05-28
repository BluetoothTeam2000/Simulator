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

namespace Simulator
{
    public partial class Menu : Form
    {
        BluetoothClient client;
        BluetoothDeviceInfo[] devices;
        static BluetoothDeviceInfo selectedDevice;
        static bool isPaired = false;

        public Menu()
        {
            InitializeComponent();
            labelInfo.Text = "";
            Console.WriteLine("Paired: "+isPaired);
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
                if (BluetoothSecurity.PairRequest(selectedDevice.DeviceAddress, null))
                {
                    isPaired = true;
                    MessageBox.Show("We paired!");
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
                BluetoothClient remoteDevice = ((BluetoothListener)result.AsyncState).EndAcceptBluetoothClient(result);
                Console.WriteLine("ZWYCIESTWO!");
            }
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            if(isPaired == false)
            {
                MessageBox.Show("Connect your device first!");
            }
            else
            {
                Simulator openSimulator = new Simulator();
                openSimulator.Show();
                Hide();
            }
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            if(isPaired)
            {
                BluetoothSecurity.RemoveDevice(selectedDevice.DeviceAddress);
            }
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            client = new BluetoothClient();
            devices = client.DiscoverDevices();
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
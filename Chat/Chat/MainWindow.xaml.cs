using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat
{
    public partial class MainWindow : Window
    {
        static IPAddress remoteAddress; // host for send data
        const int remotePort = 12000; // port for send data
        const int localPort = 12000; // port for listen data
        static string username;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sendBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                username = usernameTB.Text;
                remoteAddress = IPAddress.Parse(IP_TB.Text);
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();
                SendMessage(); // send message
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SendMessage()
        {
            UdpClient client = new UdpClient(); // create UdpClient for send data
            IPEndPoint endPoint = new IPEndPoint(remoteAddress, remotePort);

            try
            {
                while (true)
                {
                    string message = messageTB.Text; // msg for send
                    message = $"{username}: {message}";
                    byte[] data = Encoding.Unicode.GetBytes(message);
                    client.Send(data, data.Length, endPoint); // sending...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void ReceiveMessage()
        {
            UdpClient receiver = new UdpClient(localPort); // UdpClient for recieve data
            receiver.JoinMulticastGroup(remoteAddress, 50);

            IPEndPoint remoteIp = null;
            string localAddress = LocalIPAddress();

            try
            {
                while (true)
                {
                    byte[] data = receiver.Receive(ref remoteIp); // recieving data

                    if (remoteIp.Address.ToString().Equals(localAddress))
                        continue;

                    string message = Encoding.Unicode.GetString(data);
                    messages.Items.Add(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                receiver.Close();
            }
        }

        private static string LocalIPAddress()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) // IPv4 
                {
                    localIP = ip.ToString();
                    break;
                }
            }

            return localIP;
        }
    }
}

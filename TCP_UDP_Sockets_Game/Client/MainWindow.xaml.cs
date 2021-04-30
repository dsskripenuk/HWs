using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient client;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void generateBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //creation of the IPEndPoint class instance
                IPEndPoint endPoint = new IPEndPoint(
                    IPAddress.Parse(IP_TB.Text),
                    Convert.ToInt32(portTB.Text)
                );
                client = new TcpClient();

                //connection setup using
                //IP data and port number
                client.Connect(endPoint);

                //getting stream writer
                using (StreamWriter sr = new StreamWriter(client.GetStream(), Encoding.Unicode))
                {
                    ////getting network stream
                    //NetworkStream nstream = client.GetStream();
                    ////converting a message string to byte array
                    //byte[] barray = Encoding.Unicode.GetBytes(textBox3.Text);
                    ////writing the whole array to network stream
                    //nstream.Write(barray, 0, barray.Length);
                    //nstream.Close();

                    Random rnd = new Random();

                    sr.WriteLine(rnd.Next(1, 100).ToString());
                }

                //closing the client
                client.Close();
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show("Socket Exception:" + sockEx.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Exception :" + Ex.Message);
            }
        }
    }
}

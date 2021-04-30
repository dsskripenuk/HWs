using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static TcpListener list;

        static List<int> numsList = new List<int>();

        static void ThreadFun()
        {
            while (true)
            {
                try
                {
                    //server informs a client that it is ready 
                    //for connection
                    TcpClient cl = list.AcceptTcpClient();

                    //reading data from network in the Unicode format
                    StreamReader sr = new StreamReader(cl.GetStream(), Encoding.Unicode);
                    string s = sr.ReadLine();
                    //adding the obtained message to the list
                    numsList.Add(Convert.ToInt32(s));
                    cl.Close();
                    //when getting the EXIT message, exit the application
                    if (s.ToUpper() == "EXIT")
                    {
                        list.Stop();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                //creating the TcpListener class instance
                //data on host and port are read
                //from text boxes
                list = new TcpListener(IPAddress.Parse("192.168.0.114"), 7777);

                //start listening to clients
                list.Start();

                //creating a separate thread to read messages
                Thread thread = new Thread(new ThreadStart(ThreadFun));
                thread.IsBackground = true;
                //start a thread
                thread.Start();

                for (int i = 0; i < numsList.Count; i++)
                {
                    if(numsList[i] == numsList.Max())
                    {
                        Console.WriteLine($"Player {i} win!");
                        return;
                    }
                }
            }
            catch (SocketException sockEx)
            {
                Console.WriteLine("Socket exception: " + sockEx.Message);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Exception : " + Ex.Message);
            }
        }


    }
}

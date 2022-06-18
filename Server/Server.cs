using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        private IPAddress ipAddr;
        private IPEndPoint localEndPoint;
        private Socket server;
        private List<Socket> clients;
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            foreach(Socket client in clients)
            {
                Send(client);
            }
            messageTextbox.Clear();
        }

        private void Connect()
        { 
            clients = new List<Socket>();
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            ipAddr = IPAddress.Any;
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            server = new Socket(AddressFamily.InterNetwork,
               SocketType.Stream, ProtocolType.IP);

            try
            {
                server.Bind(localEndPoint);
                Thread listen = new Thread(() =>
                {
                    try
                    {
                        while (true)
                        {
                            server.Listen(10);
                            Socket client = server.Accept();
                            clients.Add(client);

                            Thread recieve = new Thread(Receive);
                            recieve.IsBackground = true;
                            recieve.Start(client);
                        }
                    } catch
                    {
                        ipAddr = ipHost.AddressList[0];
                        localEndPoint = new IPEndPoint(IPAddress.Any, 11111);

                        server = new Socket(ipAddr.AddressFamily,
                                     SocketType.Stream, ProtocolType.Tcp);
                    }
                });
                listen.IsBackground = true;
                listen.Start();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Close()
        {
            server.Close();
        }

        private void Send(Socket client)
        {
            if (messageTextbox.Text != String.Empty)
                client.Send(Serialize(messageTextbox.Text));
        }

        private void Receive(object obj)
        {
            Socket client = (Socket)obj;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    addMessageToListview(message);
                }
            }
            catch
            {
                clients.Remove(client);
                client.Close();
            }
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        private object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void addMessageToListview(string message)
        {
            listView1.Items.Add(new ListViewItem()
            {
                Text = message
            });
        }
    }
}

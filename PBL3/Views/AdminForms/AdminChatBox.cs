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
using PBL3.Views.CommonForm;

namespace PBL3.Views.AdminForms
{
    public partial class AdminChatBox : Form
    {
        private IPAddress ipAddr;
        private IPEndPoint localEndPoint;
        private Socket server = null;

        private List<Socket> clients;

        public AdminChatBox()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (clients.Count == 0)
            {
                MessageBox.Show("Hiện không có người dùng nào đang online");
                messageTextbox.Texts = "";
                return;
            }

            Send(clients[0], true);
            addMessageToListview("Admin : \t" + messageTextbox.Texts);
            messageTextbox.Texts = "";
        }

        private void Connect()
        {
            clients = new List<Socket>();

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
                    }
                    catch
                    {
                        ipAddr = IPAddress.Any;
                        localEndPoint = new IPEndPoint(ipAddr, 11111);
                        server = new Socket(AddressFamily.InterNetwork,
                           SocketType.Stream, ProtocolType.IP);
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

        private void ServerClose()
        {
            foreach (Socket s in clients)
            {
                s.Close();
            }
            clients.Clear();
            server.Close();
        }

        private void Send(Socket client, bool currentWorkingSocket)
        {
            if (currentWorkingSocket)
            {
                if (messageTextbox.Texts != String.Empty)
                    client.Send(Serialize("Admin : \t" + messageTextbox.Texts));
            }
            else
            {
                client.Send(Serialize("Admin : \t" + "Hiện đang trong giao dịch khác"));
            }
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
                    if (clients.IndexOf(client) != 0 && message != "")
                    {
                        Send(client, false);
                    }
                    else
                    {
                        addMessageToListview(message);
                    }
                }
            }
            catch
            {
                clients.Remove(client);
                client.Close();
                listView1.Clear();
                listView1.Items.Add("Bắt đầu phiên nhắn tin mới");
            }
        }

        private void Disconnect(object obj)
        {
            Socket client = (Socket)obj;
            clients.Remove(client);
            client.Close();
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

        private void AdminChatBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            ServerClose();
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (clients.Count != 0)
                Disconnect(clients[0]);
            else
            {
                MessageBox.Show("Hiện không có người dùng nào đang online");
                messageTextbox.Texts = "";
            }
        }
    }
}

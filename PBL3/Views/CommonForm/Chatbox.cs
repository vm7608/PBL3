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

namespace PBL3.Views.CommonForm
{
    public partial class Chatbox : Form
    {
        public delegate void ErrorDel(Form form);
        public ErrorDel errorDel;

        private IPAddress ipAddr;
        private IPEndPoint localEndPoint;
        private Socket sender;
        public Chatbox()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            Send();
            addMessageToListview("You : \t" + messageTextbox.Texts);
        }

        private void Connect()
        {
            ipAddr = IPAddress.Parse("127.0.0.1");
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            sender = new Socket(AddressFamily.InterNetwork,
               SocketType.Stream, ProtocolType.IP);

            try
            {
                sender.Connect(localEndPoint);
            }
            // Manage of Socket's Exceptions
            catch (ArgumentNullException ane)
            {

                MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
            }

            catch (SocketException se)
            {
                throw;
            }

            catch (Exception e)
            {
                MessageBox.Show("Unexpected exception : {0}", e.ToString());
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        private void Close()
        {
            sender.Close();
        }

        private void Send()
        {
            if (!sender.Connected)
            {
                MessageBox.Show("Admin đã rời khỏi cuộc trò chuyện!");
                errorDel(new Dashboard());
            }
            else
            {
                if (messageTextbox.Texts != String.Empty)
                    sender.Send(Serialize("User : \t" + messageTextbox.Texts));
            }
        }

        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    sender.Receive(data);

                    string message = (string)Deserialize(data);
                    addMessageToListview(message);
                }
            }
            catch
            {
                Close();
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
            messageTextbox.Texts = "";
        }

        private void Chatbox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}

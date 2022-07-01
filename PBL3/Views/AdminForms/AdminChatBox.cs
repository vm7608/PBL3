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
        private IPAddress ipAddr; //Địa chỉ ip mà thằng server sẽ lắng nghe
        private IPEndPoint localEndPoint; //Endpoint = địa chỉ ip + số hiệu cổng
        private Socket server = null;

        private List<Socket> clients; //Danh sách lưu thông tin các clients đã kết nối đến server
        private List<String> Usernames; //Danh sách lưu thông tin tên của các clients ở danh sách trên

        public AdminChatBox()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Usernames = new List<string>();
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (clients.Count == 0)
            {
                MessageBox.Show("Hiện không có người dùng nào đang online!");
                messageTextbox.Texts = "";
                return;
            }

            //Chỉ gửi tin nhắn cho thằng client đầu tiên trong list
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
                //Server sẽ nằm tại vị trí có ip là bất kì địa chỉ nào và lắng nghe tại cổng 11111
                server.Bind(localEndPoint);
                //Bắt đầu luồng lắng nghe các yêu cầu connect từ client
                Thread listen = new Thread(() =>
                {
                    try
                    {
                        while (true)
                        {
                            server.Listen(10);
                            Socket client = server.Accept();
                            //Nếu như có client kết nối tới server thì thêm nó vào list clients
                            clients.Add(client);

                            //Với mỗi client thì bắt đầu một luồng chạy hàm Receive tương ứng với client đó
                            Thread recieve = new Thread(Receive);
                            recieve.IsBackground = true;
                            recieve.Start(client);
                        }
                    }
                    catch
                    {
                        //Khởi tạo lại thông tin cho server
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

        //Sử dụng khi đóng server
        private void ServerClose()
        {
            foreach (Socket s in clients)
            {
                //Đóng kết nối tới client
                s.Close();
            }
            clients.Clear();
            Usernames.Clear();
            server.Close();
        }

        private void Send(Socket client, bool currentWorkingSocket)
        {
            //Chỉ gửi tin nhắn đến client đầu tiên trong list clients
            //Những client khác thì sẽ nhận được tin nhắn admin đang trong trò chuyện khác
            if (currentWorkingSocket)
            {
                if (messageTextbox.Texts != String.Empty)
                    client.Send(Serialize("Admin : \t" + messageTextbox.Texts));
            }
            else
            {
                client.Send(Serialize("Admin : \t" + "Hiện đang trong cuộc trò chuyện khác!"));
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
                    //Nếu client đã thoát cuộc trò chuyện thì đoạn code dưới đây sẽ ném Exception
                    client.Receive(data);

                    string message = (string)Deserialize(data);
                    if (!message.Contains("User :"))
                    {
                        Usernames.Add(message);
                    }

                    //Nếu như nhận tin nhắn từ client nhưng client này không phải là client
                    //đầu tiên trong list
                    if (clients.IndexOf(client) != 0 && message != "")
                    {
                        Send(client, false);
                    }
                    else
                    { 
                        if (listView1.Items.Count == 0)
                            message = "Bắt đầu phiên nhắn tin với " + Usernames[0];
                        if (label1.Text == "")
                            label1.Text = "Gửi đến : " + Usernames[0];
                        addMessageToListview(message);
                    }
                }
            }
            catch
            {
                /*
                 * Đặt câu lệnh if ở đây bởi vì khi form chatbox này đóng lại nó sẽ đóng tất cả kết nối của client
                 * Vậy nên nếu như kết nối đã đóng r mà ở câu lệnh catch dưới đây không có if nó sẽ đóng kết nối 
                 * của client 2 lần dẫn đến lỗi
                 */
                if (clients.Contains(client))
                {
                    int index = clients.IndexOf(client);
                    clients.Remove(client);
                    Usernames.RemoveAt(index);
                    client.Close();
                    listView1.Clear();
                    label1.Text = "";
                }
            }
        }

        //Ngắt kết nối với client truyền là đối số
        private void Disconnect(object obj)
        {
            Socket client = (Socket)obj;
            int index = clients.IndexOf(client);
            clients.Remove(client);
            Usernames.RemoveAt(index);
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
            {
                Disconnect(clients[0]);
                listView1.Clear();
                label1.Text = "";
                if (clients.Count != 0)
                {
                    String message = "";
                    if (listView1.Items.Count == 0)
                        message = "Bắt đầu phiên nhắn tin với " + Usernames[0];
                    if (label1.Text == "")
                        label1.Text = "Gửi đến : " + Usernames[0];
                    addMessageToListview(message);
                }
            }
            else
            {
                MessageBox.Show("Hiện không có người dùng nào đang online!");
                messageTextbox.Texts = "";
            }
        }
    }
}

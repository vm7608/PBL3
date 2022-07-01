using PBL3.BLL;
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

namespace PBL3.Views.CommonForm
{
    public partial class Chatbox : Form
    {
        public delegate void ErrorDel(Form form);
        public ErrorDel errorDel;

        private IPAddress ipAddr; //Địa chỉ ip mà client sẽ kết nối tới
        private IPEndPoint localEndPoint; //Endpoint nó sẽ gồm địa chỉ ip + số hiệu cổng
        private Socket sender; //Socket bên phía client

        /*
         * Work flow :
         * 1. Connect đến server có địa chỉ ip ở trên và số hiệu cổng được truyền cho Endpoint ở trên
         * 2. Gửi và nhận tin nhắn
         * 3. Disconnect khi form đóng hoặc khi Admin rời cuộc trò chuyện
         * Giải thích cụ thể bên dưới
         */
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

        //Phương thức dùng để kết nối đến server
        private void Connect()
        {
            ipAddr = IPAddress.Parse("127.0.0.1");
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            sender = new Socket(AddressFamily.InterNetwork,
               SocketType.Stream, ProtocolType.IP);
            try
            {
                //client đang cố kết nối tới server có địa chỉ ip là 127.0.0.1(Địa chỉ localhost) và 
                //Server này đang lắng nghe ở cổng 11111
                sender.Connect(localEndPoint);
                //Đoạn code dưới sẽ gửi thông tin của client này đến cho server
                //nếu như nó kết nối thành công
                sender.Send(Serialize(UserBLL.Instance.GetUserFullname(LoginInfo.UserID).ToString()));
            }
            //Manage of Socket's Exceptions
            //Nếu như client k kết nối được thì nó sẽ ném ra SocketException
            catch (ArgumentNullException ane)
            {

                MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
            }

            catch (SocketException se)
            {
                //Ném exception này ra cho thằng Main Page xử lí 
                throw;
            }

            catch (Exception e)
            {
                MessageBox.Show("Unexpected exception : {0}", e.ToString());
            }
            //Nếu như client đã kết nối tới Server thành công thì ta sẽ tạo một luồng background
            //để nhận tin nhắn từ server.
            //Luồng này sẽ sống đến khi connection bị ngắt
            //Truyền đối số cho hàm tạo của Thread là hàm Receive
            //đồng nghĩa với việc luồng này sẽ thực thi hàm Receive 1 lần
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
            //Nếu như Socket sender không còn kết nối tới Server
            if (!sender.Connected)
            {
                MessageBox.Show("Admin đã rời khỏi cuộc trò chuyện!");
                errorDel(new InformationForm(LoginInfo.UserID));
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
                //Để vòng lặp vô tận ở đây đồng nghĩa với việc hàm này sẽ luôn chạy để nhận tin nhắn từ server
                while (true)
                {
                    byte[] data = new byte[1024 * 1000];
                    //Hàm Receive của Socket sender sẽ trả về một chuỗi các byte
                    sender.Receive(data);

                    //Gọi hàm Deserialize để chuyển mảng các byte về lại đối tượng Object
                    string message = (string)Deserialize(data);
                    addMessageToListview(message);
                }
            }
            //Exception xảy ra khi Admin ngắt kết nối
            catch
            {
                Close();
            }
        }

        //Chuyển đối tượng object thành một mảng các byte để gửi đi
        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        //Chuyển một mảng các byte thành đối tượng Object để đưa lên view
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

        //Khi đóng form thì ngắt kết nối
        private void Chatbox_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}

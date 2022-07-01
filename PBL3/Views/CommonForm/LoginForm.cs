using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Views.AdminForms;
using PBL3.Views.CustomerForm;
using PBL3.Views.RenterForm;

namespace PBL3.Views.CommonForm
{
    public partial class LoginForm : Form
    {
        public delegate void MyDel ();
        public MyDel hideParentForm;
        public MyDel closeParentForm;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Texts;
            string password = passwordTextbox.Texts;
            int role = AccountBLL.Instance.GetRole(username, password);
            if (role == 0)
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }
            //Gán thông tin người dùng cho LoginInfo để tạo phiên làm việc với user
            LoginInfo.UserID = UserBLL.Instance.GetUserIDByAccountID(AccountBLL.Instance.GetAccountID(username, password));
            //Thông tin nhập đúng thì sẽ dựa trên role của người dùng sẽ mở form tương ứng
            hideParentForm();
            if (role == 1)
            {
                AdminMainPage form = new AdminMainPage();
                form.ShowDialog();
            }
            else if (role == 2)
            {
                CustomerMainPage form = new CustomerMainPage();
                form.ShowDialog();
            }
            else if (role == 3)
            {
                RenterMainPage form = new RenterMainPage();
                form.ShowDialog();
            }
            closeParentForm();
        }
        #region ->Show - Hide Password
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.PasswordChar == false)
            {
                btn_Show.BringToFront();
                passwordTextbox.PasswordChar = true;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.PasswordChar == true)
            {
                btn_Hide.BringToFront();
                passwordTextbox.PasswordChar = false;
            }
        }
        #endregion

        public delegate void openlinklabel();
        public openlinklabel OpenForm;
        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm();
        }
    }
}

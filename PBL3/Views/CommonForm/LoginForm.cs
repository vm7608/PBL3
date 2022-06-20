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

        public delegate void showPostDetail(Form childForm);
        public showPostDetail showForm;

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            showForm(form);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Texts;
            string password = passwordTextbox.Texts;

            int role = AccountBLL.Instance.GetRole(username, password);
            //Thong tin nhap sai nên phải return để tránh việc tắt form login
            if (role == 0)
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }
            //Gán thông tin người dùng cho LoginInfo để sử dụng cho các form
            LoginInfo.UserID = UserBLL.Instance.GetUserIDByAccountID(AccountBLL.Instance.GetAccountID(username, password));

            //Thông tin nhập đúng thì chọn form tương ứng và tắt form login đi
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
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.BLL;

namespace PBL3.Views.CommonForm
{
    public partial class MainPageForm : Form
    {
        //Form hiện tại đang được hiển thị trên panel con
        private Form activeForm = null;

        public MainPageForm()
        {
            InitializeComponent();
            //Sử dụng đến đối tượng context để nó áp dụng các chiến thuật khởi tạo db
            //nhằm khởi tạo db và seed data để tránh việc
            //khi vào app mới sử dụng context sẽ gây lag khi context được sử dụng lần đầu
            PostBLL.Instance.LoadApp();
        }

        public void OpenHouseInfo(Form form)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        //Tắt form hiện tại đang hiển thị trên child panel
        //và hiển thị form tương ứng được truyền vào là đối số
        public void OpenChildForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        #region ->Sidebar button clicked
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.showPost = OpenHouseInfo;
            OpenChildForm(form);
        }
        public void OpenSignUp()
        {
            SignUpForm form = new SignUpForm();
            form.OpenForm = OpenLogin;
            OpenChildForm(form);
        }
        public void OpenLogin()
        {
            LoginForm form = new LoginForm();
            form.OpenForm = OpenSignUp;
            form.hideParentForm = HideMainPageForm;
            form.closeParentForm = CloseMainPageForm;
            OpenChildForm(form);
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.OpenForm = OpenSignUp;
            form.hideParentForm = HideMainPageForm;
            form.closeParentForm = CloseMainPageForm;
            OpenChildForm(form);
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.OpenForm = OpenLogin;
            OpenChildForm(form);
        }
        #endregion
        /*
         * CloseMainPageForm và HideMainPageForm được truyền là delegate cho form login để nó sử dụng khi
         * người dùng đăng nhập thành công.
         */
        private void CloseMainPageForm()
        {
            this.Close();
        }
        private void HideMainPageForm()
        {
            this.Hide();
        }
    }
}

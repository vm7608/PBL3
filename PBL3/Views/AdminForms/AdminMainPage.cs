using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Views.CommonForm;
using PBL3.BLL;

namespace PBL3.Views.AdminForms
{
    public partial class AdminMainPage : Form
    {
        private Form activeForm = null;
        public AdminMainPage()
        {
            InitializeComponent();
            label_UserFullname.Text = UserBLL.Instance.GetUserFullname(LoginInfo.UserID).ToString();
        }
        private void OpenChildForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
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
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            //form.showPost = OpenChildForm;
            form.showPost = OpenHouseInfo;

            OpenChildForm(form);
        }

        private void articleManagementBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticleManagementForm());
        }

        private void informationManagementBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserManagementForm());
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            AdminChatBox form = new AdminChatBox();
            OpenChildForm(form);
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            //Reset lả loginInfo
            LoginInfo.UserID = -1;

            //Hiển thị lại form main page
            this.Hide();
            MainPageForm form = new MainPageForm();
            form.ShowDialog();
            this.Close();
        }
    }
}

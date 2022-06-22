using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Views.CommonForm;
using PBL3.Views.AdminForms;
namespace PBL3.Views.CustomerForm
{
    public partial class CustomerMainPage : Form
    {
        private Form activeForm = null;
        public CustomerMainPage()
        {
            InitializeComponent();
            label_UserFullname.Text = UserBLL.Instance.GetUserFullname(LoginInfo.UserID).ToString();
            panelInfomationSubmenu.Visible = false;
        }

        private void ReloadUserFullName()
        {
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

        private void hideSubmenu()
        {
            if(panelInfomationSubmenu.Visible)
                panelInfomationSubmenu.Visible = false;
        }

        private void toggleSubmenu(Panel panel){
            if (panel.Visible == false)
            {
                hideSubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            Dashboard form = new Dashboard();
            form.showPost = OpenChildForm;
            OpenChildForm(form);
        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelInfomationSubmenu);
        }

        private void articleManagementBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ArticleManagementForm form = new ArticleManagementForm();
            //form.showPost = OpenChildForm;
            OpenChildForm(form);
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            try
            {
                Chatbox form = new Chatbox();
                form.errorDel = OpenChildForm;
                OpenChildForm(form);
            } catch (SocketException ex)
            {
                MessageBox.Show("Admin đang offline");
                OpenChildForm(new InformationForm(LoginInfo.UserID));
            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            //Reset lại loginInfo
            LoginInfo.UserID = -1;

            //Hiển thị lại form main page
            this.Hide();
            MainPageForm form = new MainPageForm();
            form.ShowDialog();
            this.Close();
        }

        private void idBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InformationForm(LoginInfo.UserID));
        }

        private void infomationChangeBtn_Click(object sender, EventArgs e)
        {
            InformationUpdateForm form = new InformationUpdateForm();
            form.ReloadInformation = ReloadUserFullName;
            OpenChildForm(form);
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePasswordForm());
        }

       

    }
}

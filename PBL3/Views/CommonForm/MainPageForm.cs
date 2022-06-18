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
        private Form activeForm = null;

        public MainPageForm()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            form.showPost = OpenChildForm;
            OpenChildForm(form);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.showForm = OpenChildForm;
            form.hideParentForm = HideMainPageForm;
            form.closeParentForm = CloseMainPageForm;
            OpenChildForm(form);
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.showForm = OpenChildForm;
            OpenChildForm(form);
        }

        public void OpenChildForm(Form form)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.Views.CommonForm
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        private bool validatePassword()
        {
            if (newPassTextbox.Texts != confirmNewPassField.Texts)
                return false;
            return true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!validatePassword())
                MessageBox.Show("Mật khẩu xác nhận không chính xác!");
            else
            {
                int userID = LoginInfo.UserID;
                if(AccountBLL.Instance.CheckPassword(UserBLL.Instance.GetAccountIDByUserID(userID), oldPassTextbox.Texts))
                {
                    AccountBLL.Instance.ChangePassword(UserBLL.Instance.GetAccountIDByUserID(userID), newPassTextbox.Texts);
                    MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                    this.Close();
                } else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

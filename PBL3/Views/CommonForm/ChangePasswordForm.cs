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
        #region -> Show - Hide Password

        private void btn_ShowOld_Click(object sender, EventArgs e)
        {
            if (oldPassTextbox.PasswordChar == true)
            {
                btn_HideOld.BringToFront();
                oldPassTextbox.PasswordChar = false;
            }
        }

        private void btn_HideOld_Click(object sender, EventArgs e)
        {
            if (oldPassTextbox.PasswordChar == false)
            {
                btn_ShowOld.BringToFront();
                oldPassTextbox.PasswordChar = true;
            }
        }

        private void btn_Shownew_Click(object sender, EventArgs e)
        {
            if (newPassTextbox.PasswordChar == true)
            {
                btn_hidenew.BringToFront();
                newPassTextbox.PasswordChar = false;
            }
        }

        private void btn_hidenew_Click(object sender, EventArgs e)
        {
            if (newPassTextbox.PasswordChar == false)
            {
                btn_Shownew.BringToFront();
                newPassTextbox.PasswordChar = true;
            }
        }

        private void btn_ShowConfirm_Click(object sender, EventArgs e)
        {
            if (confirmNewPassField.PasswordChar == true)
            {
                btn_HideConfirm.BringToFront();
                confirmNewPassField.PasswordChar = false;
            }
        }

        private void btn_HideConfirm_Click(object sender, EventArgs e)
        {
            if (confirmNewPassField.PasswordChar == false)
            {
                btn_ShowConfirm.BringToFront();
                confirmNewPassField.PasswordChar = true;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.Views.CommonForm
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            LoadCBB();
        }

        #region ->Load CBB
        public void LoadCBB()
        {
            CBBItem AllDistrict = new CBBItem
            {
                Value = 0,
                Text = "Tất cả quận"
            };
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbb_District.Items.Add(AllDistrict);
            var listDistrict = DistrictBLL.Instance.GetAllDistricts();

            foreach (var i in listDistrict)
            {
                cbb_District.Items.Add(new CBBItem
                {
                    Value = i.DistrictID,
                    Text = i.DistrictName.ToString()
                });
            }
            cbb_District.SelectedItem = AllDistrict;
            cbb_Ward.Items.Add(AllWard);
            cbb_Ward.SelectedItem = AllWard;
        }
        private void cbb_District_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            if (((CBBItem)cbb_District.SelectedItem).Value == 0)
            {
                LoadCBB();
            }
            else
            {
                CBBItem AllWard = new CBBItem
                {
                    Value = 0,
                    Text = "Tất cả phường"
                };
                int districtID = ((CBBItem)cbb_District.SelectedItem).Value;
                cbb_Ward.Items.Clear();
                cbb_Ward.Items.Add(AllWard);
                var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
                foreach (var i in WardInDistrict)
                {
                    cbb_Ward.Items.Add(new CBBItem
                    {
                        Value = i.WardID,
                        Text = i.WardName
                    });
                }
                cbb_Ward.SelectedItem = AllWard;
            }
        }
        #endregion

        #region ->Validation
        //Kiểm tra xem mật khẩu nhập lại có chính xác không
        public bool checkFailRetypePassword()
        {
            if (textBox_Password.Texts != textBox_RetypePassword.Texts) {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại!");
                return true;
            };
            return false;
        }

        //Kiểm tra username tồn tại hay chưa
        public bool checkExistUsername()
        {
            if(AccountBLL.Instance.CheckExistingUsername(textBox_Username.Texts))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên đăng nhập khác!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem có ô nào còn bỏ trống không và đã chọn phường chưa
        public bool checkEmpty()
        {
            if(textBox_Name.Texts == "" || textBox_Email.Texts == "" || textBox_Phone.Texts == "" ||
                textBox_Password.Texts == ""|| textBox_RetypePassword.Texts == "" || textBox_DetailAddress.Texts == ""||
                (radioButton_Host.Checked == false && radioButton_Renter.Checked == false) || cbb_Ward.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem địa chỉ email có hợp lí hay không! Yêu cầu phải có định dạng user@host
        //hoặc user@host.abc
        public bool checkIsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng địa chỉ email user@host");
                return false;
            }
        }

        #endregion

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            //Validation
            if (checkEmpty()) return;
            if (checkExistUsername()) return;
            if (checkFailRetypePassword()) return;
            if (!checkIsValidEmailAddress(textBox_Email.Texts)) return;

            //Thêm tài khoản
            int roleID = radioButton_Host.Checked? 2:3;
            int accID = AccountBLL.Instance.AddAccount(new Account
            {
                Username = textBox_Username.Texts,
                Password = PasswordHashing.EncodePasswordToBase64(textBox_Password.Texts),
                RoleID = roleID,
                CreatedAt = DateTime.Now
            });

            //Thêm địa chỉ
            int addressID = AddressBLL.Instance.AddAddress(new Address
            {
                DetailAddress = textBox_DetailAddress.Texts,
                WardID = ((CBBItem)cbb_Ward.SelectedItem).Value
            });

            //Thêm người dùng
            UserBLL.Instance.AddUser(new User
            {
                FullName = textBox_Name.Texts,
                Phone = textBox_Phone.Texts,
                Email = textBox_Email.Texts,
                AccountID = accID,
                AddressID = addressID
            });

            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }
        public delegate void openlinklabel();
        public openlinklabel OpenForm;
        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm();
        }

        #region ->Show - hide pass
        private void btn_ShowPass_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == true)
            {
                btn_HidePass.BringToFront();
                textBox_Password.PasswordChar = false;
            }
        }

        private void btn_HidePass_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == false)
            {
                btn_ShowPass.BringToFront();
                textBox_Password.PasswordChar = true;
            }
        }

        private void btn_ShowConFirm_Click(object sender, EventArgs e)
        {
            if (textBox_RetypePassword.PasswordChar == true)
            {
                btn_HideConfirm.BringToFront();
                textBox_RetypePassword.PasswordChar = false;
            }
        }

        private void btn_HideConfirm_Click(object sender, EventArgs e)
        {
            if (textBox_RetypePassword.PasswordChar == false)
            {
                btn_ShowConFirm.BringToFront();
                textBox_RetypePassword.PasswordChar = true;
            }
        }
        #endregion
    }
}

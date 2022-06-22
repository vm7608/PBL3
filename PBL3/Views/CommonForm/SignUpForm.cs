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
using PBL3.DTO;

namespace PBL3.Views.CommonForm
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            loadCBB();
        }
        #region Load CBB
        public void loadCBB()
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
                loadCBB();
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
        //??
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showForm;

        public bool checkFailRetypePassword()
        {
            if (textBox_Password.Texts != textBox_RetypePassword.Texts) {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại!");
                return true;
            };
            return false;
        }
        public bool checkExistUsername()
        {
            if(AccountBLL.Instance.CheckExistingUsername(textBox_Username.Texts))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên đăng nhập khác!");
                return true;
            }
            return false;
        }
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
        private void button_SignUp_Click(object sender, EventArgs e)
        {
            if (checkEmpty()) return;
            if (checkExistUsername()) return;
            if (checkFailRetypePassword()) return;

            //add account
            int roleID = radioButton_Host.Checked? 2:3;
            int accID = AccountBLL.Instance.AddAccount(new Account
            {
                Username = textBox_Username.Texts,
                Password = textBox_Password.Texts,
                RoleID = roleID,
                CreatedAt = DateTime.Now,
                ModifiedAt = null
            });

            //add address
            int addressID = AddressBLL.Instance.AddAddress(new Address
            {
                DetailAddress = textBox_DetailAddress.Texts,
                WardID = ((CBBItem)cbb_Ward.SelectedItem).Value
            });

            //add user
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

        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            showForm(form);
        }

    }
}

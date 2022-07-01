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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PBL3.Views.CustomerForm
{
    public partial class InformationUpdateForm : Form
    {
        //Form update thông tin cá nhân
        public delegate void MyDel();
        public MyDel ReloadInformation;
        public InformationUpdateForm()
        {
            InitializeComponent();
            LoadCBB();
            LoadUserInformation();
        }

        #region ->Load CBB
        public void ResetCBB()
        {
            cbb_District.Items.Clear();
            cbb_District.DataSource = null;
            cbb_District.ResetText();

            cbb_Ward.Items.Clear();
            cbb_Ward.DataSource = null;
            cbb_Ward.ResetText();
        }
        public void LoadCBB()
        {
            ResetCBB();
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

        public void SetCBB()
        {
            //Khởi tạo giá trị ban đầu cho CBB tương ứng với dữ liệu của user trên database
            int addressID = UserBLL.Instance.GetAddressIDByUserID(LoginInfo.UserID);
            int districtID = AddressBLL.Instance.GetDistrictIDByAddressID(addressID);
            int wardID = AddressBLL.Instance.GetWardIDByAddressID(addressID);
            //Set selected item của quận cbb tương ứng với dữ liệu của người dùng
            foreach (var i in cbb_District.Items)
            {
                if (((CBBItem)i).Value == districtID)
                {
                    cbb_District.SelectedItem = i;
                    break;
                }
            }
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbb_Ward.Items.Clear();
            cbb_Ward.Items.Add(AllWard);
            //Lấy các phường trong quận để load cbb tương ứng
            var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
            foreach (var i in WardInDistrict)
            {
                cbb_Ward.Items.Add(new CBBItem
                {
                    Value = i.WardID,
                    Text = i.WardName
                });
            }
            //Set selected item của phường tương ứng với dữ liệu của user trên db
            foreach (var i in cbb_Ward.Items)
            {
                if (((CBBItem)i).Value == wardID)
                {
                    cbb_Ward.SelectedItem = i;
                    break;
                }
            }
        }
        private void LoadUserInformation ()
        {
            //Set thông tin ban đầu tương ứng với dữ liệu của người dùng trên db
            User thisUser = UserBLL.Instance.GetUserByID(LoginInfo.UserID);
            txt_Fullname.Texts = thisUser.FullName;
            txt_Mail.Texts = thisUser.Email;
            txt_Phone.Texts = thisUser.Phone;
            txt_DetailAddress.Texts = AddressBLL.Instance.GetDetailAddress(thisUser.AddressID);
            SetCBB();
        }
        private bool checkEmpty()
        {
            //Check thông tin đầy đủ chưa
            if(txt_Fullname.Texts == "" || txt_Mail.Texts == "" || txt_Phone.Texts == "" || cbb_Ward.SelectedIndex == 0
                || txt_DetailAddress.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }
        private bool checkIsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng địa chỉ email!");
                return false;
            }
        }
        public bool CheckPhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại có 10 chữ số!");
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate thông tin có empty không
            if (checkEmpty()) return;
            if (!checkIsValidEmailAddress(txt_Mail.Texts)) return;
            if (!CheckPhoneNumber(txt_Phone.Texts)) return;
            User userInfo = new User
            {
                UserID = LoginInfo.UserID,
                FullName = txt_Fullname.Texts,
                Phone = txt_Phone.Texts,
                Email = txt_Mail.Texts,
            };
            Address addInfo = new Address
            {
                DetailAddress = txt_DetailAddress.Texts,
                WardID = ((CBBItem)cbb_Ward.SelectedItem).Value
            };
            UserBLL.Instance.UpdateUserInformation(userInfo, addInfo);
            MessageBox.Show("Thay đổi thông tin thành công!");
            ReloadInformation();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

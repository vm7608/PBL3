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
namespace PBL3.Views.CustomerForm
{
    public partial class InformationUpdateForm : Form
    {
        public InformationUpdateForm()
        {
            InitializeComponent();
            loadCBB();
        }
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
        public bool checkEmpty()
        {
            if(txt_Fullname.Texts == "" || txt_Mail.Texts == "" || txt_Phone.Texts == "" || cbb_Ward.SelectedIndex == 0
                || txt_DetailAddress.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate thông tin có empty không
            if (checkEmpty()) return;

            //edit lại
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

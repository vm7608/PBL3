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
    public partial class InformationForm : Form
    {
        public InformationForm(int userID)
        {
            InitializeComponent();
            InitializeInformation(userID);
        }

        private void InitializeInformation(int userID)
        {
            User user = UserBLL.Instance.GetUserByID(userID);
            label_Fullname.Text += user.FullName;
            label_Phone.Text += user.Phone;
            label_Email.Text += user.Email;
            label_Address.Text += AddressBLL.Instance.GetFullAddress(user.AddressID);
        }

    }
}

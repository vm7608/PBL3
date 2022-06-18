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
using PBL3.Views.CommonForm;
namespace PBL3.Views.AdminForms
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = UserBLL.Instance.GetAllUser();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Users.ToList();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này?!", "Lưu ý", MessageBoxButtons.YesNo);

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 người dùng!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem thông tin mỗi lần 1 người dùng!");
                return;
            }
            int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            InformationForm form = new InformationForm(userID);
            form.Visible = false;
            form.ShowDialog();
        }
    }
}

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
            cbbUserRole.SelectedIndex = 0;
            cbbSort.SelectedIndex = 0;
            ShowDTG();
        }
        public void LoadHeader()
        {
            var headername = new List<string>()
            {
                "STT",
                "User ID",
                "Loại tài khoản",
                "Họ và tên",
                "Email",
                "Điện thoại",
                "Địa chỉ",
                "Số bài đăng",
                "Số bình luận",
                "Tham gia lúc"
            };
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headername[i];
            }
            dataGridView1.Columns["UserID"].Visible = false;
        }
        public void ShowDTG()
        {
            string searchChars = txt_Search.Texts;
            int sortCase = cbbSort.SelectedIndex;
            string rolename = "All";
            if (cbbUserRole.SelectedIndex == 1) rolename = "Người cho thuê";
            if (cbbUserRole.SelectedIndex == 2) rolename = "Người thuê";
            dataGridView1.DataSource = UserBLL.Instance.SearchUser(searchChars, rolename, sortCase, checkAscending);
            LoadHeader();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 tài khoản cần xoá!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xoá một lần 1 tài khoản");
                return;
            }
            int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString());

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này không ?",
                "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserBLL.Instance.DeleteUser(userID);
                MessageBox.Show("Xoá thành công!");
                ShowDTG();

            }
            else
                return;
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
            int userID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString());
            InformationForm form = new InformationForm(userID);
            form.Visible = false;
            form.ShowDialog();
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Load cột số thứ tự tự động
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private static bool checkAscending = true;
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            checkAscending = !checkAscending;
            ShowDTG();
        }
        private void cbbSort_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            checkAscending = true;
            ShowDTG();
        }
        private void cbbUserRole_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = 0;
            checkAscending = true;
            ShowDTG();
        }
    }
}

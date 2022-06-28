﻿using System;
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
            LoadFilter();
        }
        public void LoadHeader()
        {
            var headername = new List<string>()
                    {
                        "STT",
                        "UserID",
                        "Loại tài khoản",
                        "Họ và tên",
                        "Email",
                        "SĐT",
                        "Địa chỉ",
                        "Số bài đăng",
                        "Số bình luận"
                    };
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headername[i];
            }
            dataGridView1.Columns["UserID"].Visible = false;
        }
        private void LoadFilter()
        {
            cbbUserRole.SelectedIndex = 0;
            dataGridView1.DataSource = UserBLL.Instance.GetAllUser();
            LoadHeader();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchChars = txt_Search.Texts;
            string rolename = "All";
            if (cbbUserRole.SelectedIndex == 1) rolename = "Host";
            if (cbbUserRole.SelectedIndex == 2) rolename = "Renter";
            dataGridView1.DataSource = UserBLL.Instance.SearchUser(searchChars, rolename);
            LoadHeader();
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
                dataGridView1.DataSource = UserBLL.Instance.GetAllUser();
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
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}

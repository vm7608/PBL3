﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Views.CommonForm;
using PBL3.BLL;
namespace PBL3.Views.CustomerForm
{
    public partial class ArticleManagementForm : Form
    {
        public ArticleManagementForm()
        {
            InitializeComponent();
            cbbSort.SelectedIndex = 0;
            postedFilterCbb.SelectedIndex = 0;
            ShowDTG();
        }
        public void LoadHeader()
        {
            var headername = new List<string>()
            {
                "STT",
                "Post ID",
                "User ID",
                "Tên người dùng",
                "Tiêu đề",
                "Địa chỉ",
                "Rating",
                "Số bình luận",
                "Trạng thái duyệt",
                "Trạng thái thuê",
                "Tạo lúc",
                "Duyệt lúc",
                "Chỉnh sửa lúc"
            };
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headername[i];
            }
            dataGridView1.Columns["PostID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["Username"].Visible = false;

        }
        private void UpdateDatagridView()
        {
            postedFilterCbb.SelectedIndex = 0;
            dataGridView1.DataSource = PostBLL.Instance.GetAllPostView(LoginInfo.UserID);
            LoadHeader();
        }
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showPost;
        public void ReOpen()
        {
            this.Show();
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 bài đăng!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem mỗi lần 1 bài đăng!");
                return;
            }
            int postID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bool isPosted = PostBLL.Instance.CheckPosted(postID);

            HouseInformationForm form = new HouseInformationForm(Convert.ToInt32(postID), !isPosted);
            form.goback = ReOpen;
            showPost(form);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 bài đăng!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được cập nhật mỗi lần 1 bài đăng!");
                return;
            }
            int postID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            ArticleUpdateForm form = new ArticleUpdateForm(postID);
            form.Visible = false;
            form.ShowDialog();
            UpdateDatagridView();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ArticlePostingForm form = new ArticlePostingForm();
            form.ShowDialog();
            UpdateDatagridView();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá ? Sau khi xoá không thể thực hiện lại!",
                "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    PostBLL.Instance.DeletePost(Convert.ToInt32(row.Cells["PostID"].Value.ToString()));
                }
                MessageBox.Show("Xoá thành công!");
                UpdateDatagridView();
            }
            else
                return;
        }

        public void ShowDTG()
        {
            int searchFilter = postedFilterCbb.SelectedIndex;
            string searchChars = txt_Search.Texts;
            int sortCase = cbbSort.SelectedIndex;
            dataGridView1.DataSource = PostBLL.Instance.GetDTGView(searchFilter, sortCase, checkAscending, searchChars, LoginInfo.UserID);
            LoadHeader();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }
        private void cbbSort_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            checkAscending = true;
            ShowDTG();
        }
        private static bool checkAscending = true;
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            checkAscending = !checkAscending;
            ShowDTG();
        }
        private void postedFilterCbb_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = 0;
            checkAscending = true;
            ShowDTG();
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //Load cột số thứ tự tự động
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}

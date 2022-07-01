using System;
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
namespace PBL3.Views.AdminForms
{
    public partial class ArticleManagementForm : Form
    {
        private static bool checkAscending = true; //kiểm tra sort ascending hay descending
        public ArticleManagementForm()
        {
            InitializeComponent();
            cbbSort.SelectedIndex = 0;
            postedFilterCbb.SelectedIndex = 0;
            ShowDTG();
        }
        #region ->Delegate mở lại form
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showPost;
        public void ReOpen()
        {
            this.Show();
            ShowDTG();
        }
        #endregion
        public void LoadHeader()
        {
            //Load lại tên các cột
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
            //Ẩn các cột không cần thiết
            dataGridView1.Columns["PostID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
        }
        public void ShowDTG()
        {
            //Hiển thị thông tin lên DTG theo các filter, search, sort
            int searchFilter = postedFilterCbb.SelectedIndex;
            string searchChars = txt_Search.Texts;
            int sortCase = cbbSort.SelectedIndex;
            dataGridView1.DataSource = PostBLL.Instance.GetDTGView(searchFilter, sortCase, checkAscending, searchChars);
            LoadHeader();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            //Xem chi tiết bài đăng
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 bài đăng!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem mỗi lần 1 bài đăng");
                return;
            }
            int postID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PostID"].Value.ToString());
            bool isPosted = PostBLL.Instance.CheckPosted(postID);
            //nếu bài đã post thì cho hiện cmt và rating, ngược lại ẩn cmt và rating
            HouseInformationForm form = new HouseInformationForm(Convert.ToInt32(postID), !isPosted);
            form.goback = ReOpen;
            showPost(form);
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //Duyệt bài đăng
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 bài đăng!");
                return;
            }
            else if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được duyệt mỗi lần 1 bài đăng!");
                return;
            }
            int postID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PostID"].Value.ToString());
            if (PostBLL.Instance.CheckPosted(postID))
            {
                MessageBox.Show("Bài đăng này đã được duyệt!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn duyệt bài đăng này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PostBLL.Instance.AcceptPost(postID);
                    MessageBox.Show("Duyệt bài thành công!");
                    ShowDTG();
                }
                else
                    return;
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //Xóa bài đăng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá ? Sau khi xoá không thể thực hiện lại",
                "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    PostBLL.Instance.DeletePost(Convert.ToInt32(row.Cells["PostID"].Value.ToString()));
                }
                MessageBox.Show("Xoá thành công!");
                ShowDTG();
            }
            else
                return;
        }
        private void viewUser_Click(object sender, EventArgs e)
        {
            //Xem thông tin người đăng
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng!");
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
        private void searchBtn_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }
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

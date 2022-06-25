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
namespace PBL3.Views.CustomerForm
{
    public partial class ArticleManagementForm : Form
    {
        public ArticleManagementForm()
        {
            InitializeComponent();
            UpdateDatagridView();
        }
        public void LoadHeader()
        {
            var headername = new List<string>()
                    {
                        "Post ID",
                        "Tiêu đề",
                        "Địa chỉ",
                        "Mô tả",
                        "Giá tiền",
                        "Diện tích",
                        "Tạo lúc",
                        "Trạng thái duyệt",
                        "Trạng thái thuê"
                    };
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].HeaderText = headername[i];
            }
        }
        private void UpdateDatagridView()
        {
            postedFilterCbb.SelectedIndex = 0;
            dataGridView1.DataSource = PostBLL.Instance.GetAllPostView(LoginInfo.UserID);
            LoadHeader();
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
            HouseInformationForm form = new HouseInformationForm(postID, true, true);
            form.Visible = false;
            form.ShowDialog();
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int searchCase = postedFilterCbb.SelectedIndex;
            switch (searchCase)
            {
                case 0: //Tất cả bài đăng
                    dataGridView1.DataSource = PostBLL.Instance.GetAllPostView(LoginInfo.UserID);
                    LoadHeader();
                    break;
                case 1: //Theo thời gian tạo => mới nhất
                    dataGridView1.DataSource = PostBLL.Instance.GetNewestPost(LoginInfo.UserID);
                    LoadHeader();
                    break;
                case 2: //Bài đăng đã được duyệt
                    dataGridView1.DataSource = PostBLL.Instance.GetPublishedPost(true, LoginInfo.UserID);
                    LoadHeader();
                    break;
                case 3: //Bài đăng chưa được duyệt
                    dataGridView1.DataSource = PostBLL.Instance.GetPublishedPost(false, LoginInfo.UserID);
                    LoadHeader();
                    break;
                case 4: //Bài đăng đã cho thuê
                    dataGridView1.DataSource = PostBLL.Instance.GetRentedPost(true, LoginInfo.UserID);
                    LoadHeader();
                    break;
                case 5: //Bài đăng chưa cho thuê
                    dataGridView1.DataSource = PostBLL.Instance.GetRentedPost(false, LoginInfo.UserID);
                    LoadHeader();
                    break;
                default:
                    dataGridView1.DataSource = PostBLL.Instance.GetAllPostView(LoginInfo.UserID);
                    LoadHeader();
                    break;
            }
        }
    }
}

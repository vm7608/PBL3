using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using PBL3.Properties;
using PBL3.DTO;
using PBL3.BLL;
using PBL3.DTO.ViewDTO;
using System.IO;

namespace PBL3.Views.CommonForm
{
    public partial class HouseInformationForm : Form
    {
        //User ID who write this post
        private int UserID;

        //This part is for comment section
        private int commentNum;
        private int totalCommentNum;
        private int currentCommentPage = 0;
        private int totalPage;
        private int skipNum = 4;

        //Store post information in here
        private int PostID;
        public HouseInformationForm(int postID)
        {
            PostID = postID;
            InitializeComponent();
            InitializeFormInfomation();
            InitializeImage();
            InitializeStar();
            LoadComment();
        }      

        private void Display5Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.yellow_star;
        }
        private void Display4Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.white_star;
        }
        private void Display3Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }
        private void Display2Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }
        private void Display1Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.white_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }
        private void Display0Star()
        {
            star2.Image = Resources.white_star;
            star1.Image = Resources.white_star;
            star5.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star3.Image = Resources.white_star;
        }

        private void InitializeStar()
        {
            int stars = RatingBLL.Instance.GetPostRating(PostID);
            switch (stars)
            {
                case 0:
                    AvgRatingField.Text = "0";
                    Display0Star();
                    break;
                case 1:
                    AvgRatingField.Text = "1";
                    Display1Star();
                    break;
                case 2:
                    AvgRatingField.Text = "2";
                    Display2Star();
                    break;
                case 3:
                    AvgRatingField.Text = "3";
                    Display3Star();
                    break;
                case 4:
                    AvgRatingField.Text = "4";
                    Display4Star();
                    break;
                case 5:
                    AvgRatingField.Text = "5";
                    Display5Star();
                    break;
            }
        }
        private void InitializeImage()
        {
            try
            {
                PostViewDTO post = PostBLL.Instance.GetPostByID(PostID);
                string imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(PostID);

                System.Drawing.Image image1;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[0]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image1;
                }

                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[1]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox2.Image = image1;
                }

                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[2]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox3.Image = image1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
        }

        private void InitializeFormInfomation()
        {
            PostViewDTO post = PostBLL.Instance.GetPostByID(PostID);
            addressField.Text = post.Address;
            areaField.Text = post.Area.ToString();
            titleField.Text = post.Title;
            priceField.Text = post.Price.ToString();
            DescriptionField.Text = post.Description;
            UserID = post.UserID.GetValueOrDefault();
        }

        private void LoadComment()
        {
            DisplayAllComment();
            totalCommentNum = CommentBLL.Instance.GetNumberOfComments(PostID);
            if (totalCommentNum == 0)
            {
                HideComment(0);
                return;
            }
            totalPage = (int)Math.Ceiling(totalCommentNum / Convert.ToDouble(skipNum));
            commentNum = (totalCommentNum - 4 * currentCommentPage < 4) ? totalCommentNum - 4 * currentCommentPage : 4;

            HideComment(commentNum);
            List<CommentViewDTO> comments = CommentBLL.Instance.GetComments(PostID, currentCommentPage * skipNum, commentNum);
            if (customComment1.Visible)
            {
                customComment1.Comment = comments[0].Content;
                customComment1.Username = UserBLL.Instance.GetNameInformation(comments[0].UserID);
            }
            if (customComment2.Visible)
            {
                customComment2.Comment = comments[1].Content;
                customComment2.Username = UserBLL.Instance.GetNameInformation(comments[1].UserID);
            }
            if (customComment3.Visible)
            {
                customComment3.Comment = comments[2].Content;
                customComment3.Username = UserBLL.Instance.GetNameInformation(comments[2].UserID);
            }
            if (customComment4.Visible)
            {
                customComment4.Comment = comments[3].Content;
                customComment4.Username = UserBLL.Instance.GetNameInformation(comments[3].UserID);
            }
        }

        private void DisplayAllComment()
        {
            this.Visible = true;
            panel3.Visible = true;
            customComment1.Visible = true;
            customComment2.Visible = true;
            customComment3.Visible = true;
            customComment4.Visible = true;
        }

        private void HideComment(int commentNum)
        {
            switch (commentNum)
            {
                case 3:
                    customComment4.Visible = false;
                    break;
                case 2:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    break;
                case 1:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    break;
                case 0:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    customComment1.Visible = false;
                    break;
            }
        }

        private void uploadCmtBtn_Click(object sender, EventArgs e)
        {
            if(LoginInfo.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            if (cmtTextbox.Texts != "")
            {
                CommentBLL.Instance.AddComment(LoginInfo.UserID, PostID, cmtTextbox.Texts);
                cmtTextbox.Texts = "";
            }
            else
                MessageBox.Show("Vui lòng nhập comment");
            LoadComment();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage - 1;
            if (currentCommentPage < 0)
                currentCommentPage = totalPage - 1;
            LoadComment();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage + 1;
            if (currentCommentPage == totalPage)
                currentCommentPage = 0;
            LoadComment();
        }

        private void btnHostInfo_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm(UserID);
            form.ShowDialog();
        }

    }
}

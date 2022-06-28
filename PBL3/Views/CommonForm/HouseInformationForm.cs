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
using System.Threading;
using PBL3.Views.CustomComponents;

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
        public HouseInformationForm(int postID, bool HideRatingAndCMT = false, bool HideBack = false)
        {
            PostID = postID;
            InitializeComponent();
            InitializeFormInfomation();
            InitializeImage();
            InitializeStar();
            LoadComment();
            if(HideRatingAndCMT)
            {
                panel_CmtBar.Visible = false;
                panel_Rating.Visible = false;
            } 
            if(HideBack)
            {
                button_back.Visible = false;
            }
        }
        #region Display star
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
            double Avgstars = RatingBLL.Instance.GetPostRating(PostID); //get avg star of post
            int displayStar = Convert.ToInt32(Math.Round(Avgstars)); 
            //rounded avg star ex 4.5 -> 5, 3.3 -> 3 ==> sw case to display 
            switch (displayStar)
            {
                case 0:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display0Star();
                    break;
                case 1:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display1Star();
                    break;
                case 2:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display2Star();
                    break;
                case 3:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display3Star();
                    break;
                case 4:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display4Star();
                    break;
                case 5:
                    AvgRatingField.Text = String.Format("{0:0.00}", Avgstars) + " sao";
                    Display5Star();
                    break;
            }
        }
        #endregion

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
            areaField.Text = post.Area.ToString() + " m\u00b2";
            titleField.Text = post.Title;
            priceField.Text = post.Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
            DescriptionField.Text = post.Description;
            timeField.Text = PostBLL.Instance.GetPublishedTime(PostID);
            UserID = post.UserID.GetValueOrDefault();
        }

        private void LoadComment()
        {
            HideCommentUtilityFunction();
            DisplayAllCommentComponent();
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
                customComment1.deleteCommentID = comments[0].CommentID;
                customComment1.editCommentID = comments[0].CommentID;
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[0].CommentID) == LoginInfo.UserID)
                    customComment1.DisplayUtilityPanel();
            }
            if (customComment2.Visible)
            {
                customComment2.Comment = comments[1].Content;
                customComment2.Username = UserBLL.Instance.GetNameInformation(comments[1].UserID);
                customComment2.deleteCommentID = comments[1].CommentID;
                customComment2.editCommentID = comments[1].CommentID;
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[1].CommentID) == LoginInfo.UserID)
                    customComment2.DisplayUtilityPanel();
            }
            if (customComment3.Visible)
            {
                customComment3.Comment = comments[2].Content;
                customComment3.Username = UserBLL.Instance.GetNameInformation(comments[2].UserID);
                customComment3.deleteCommentID = comments[2].CommentID;
                customComment3.editCommentID = comments[2].CommentID;
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[2].CommentID) == LoginInfo.UserID)
                    customComment3.DisplayUtilityPanel();
            }
            if (customComment4.Visible)
            {
                customComment4.Comment = comments[3].Content;
                customComment4.Username = UserBLL.Instance.GetNameInformation(comments[3].UserID);
                customComment4.deleteCommentID = comments[3].CommentID;
                customComment4.editCommentID = comments[3].CommentID;
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[3].CommentID) == LoginInfo.UserID)
                    customComment4.DisplayUtilityPanel();
            }
        }

        private void DisplayAllCommentComponent()
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

        private void btnConfirmRating_Click(object sender, EventArgs e)
        {
            int stars = GetRatingInformationOnForm();
            if(LoginInfo.UserID == -1)
            {
                MessageBox.Show("Vui lòng đăng nhập");
                return;
            }
            if(stars == -1)
            {
                MessageBox.Show("Vui lòng chọn đánh giá!");
                return;
            }
            if (RatingBLL.Instance.CheckRating(LoginInfo.UserID, PostID))
            {
                DialogResult result = MessageBox.Show($"Bạn đã rate bài viết này với " +
                    $"{RatingBLL.Instance.GetStars(LoginInfo.UserID, PostID)} sao. " +
                    $"Bạn có muốn xác nhận đánh giá lại ?",
                "Xác nhận",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RatingBLL.Instance.DeleteUserRatingInPost(LoginInfo.UserID, PostID);
                    RatingBLL.Instance.AddRating(LoginInfo.UserID, PostID, stars);
                    MessageBox.Show("Đánh giá thành công!");
                }
                else
                    return;
            } else
            {
                RatingBLL.Instance.AddRating(LoginInfo.UserID, PostID, stars);
                MessageBox.Show("Đánh giá thành công!");
            }
            InitializeStar();
        }
        private int GetRatingInformationOnForm()
        {
            if (radioButton_1star.Checked)
                return 1;
            else if (radioButton_2star.Checked)
                return 2;
            else if (radioButton_3star.Checked)
                return 3;
            else if (radioButton_4star.Checked)
                return 4;
            else if (radioButton_5star.Checked)
                return 5;
            else
                return -1;
        }
        public delegate void back();
        public back goback;
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            goback();
        }

        #region Edit and delete comment
        private void editCommentEventHandler(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            CustomLinkLabel customLinkLabel = (CustomLinkLabel)linkLabel.Parent;
            int commentID = customLinkLabel.ID;
            if(commentID != -1)
            {
                PromptDialog prompt = new PromptDialog(customLinkLabel.ID);
                prompt.ShowDialog();
                LoadComment();
            }
        }

        private void deleteCommentEventHandler(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            CustomLinkLabel customLinkLabel = (CustomLinkLabel)linkLabel.Parent;
            int commentID = customLinkLabel.ID;
            if (commentID != -1)
            {
                CommentBLL.Instance.DeleteCommentByID(commentID);
                LoadComment();
            }
        }

        private void HideCommentUtilityFunction()
        {
            customComment1.HideUtilityPanel();
            customComment2.HideUtilityPanel();
            customComment3.HideUtilityPanel();
            customComment4.HideUtilityPanel();
        }
        #endregion
    }
}

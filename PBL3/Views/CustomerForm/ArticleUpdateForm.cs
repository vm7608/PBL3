using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO.ViewDTO;
using PBL3.DTO;
namespace PBL3.Views.CustomerForm
{
    public partial class ArticleUpdateForm : Form
    {
        private int PostID;
        private List<string> ImagePathList;
        private List<string> imageFileName;
        public ArticleUpdateForm(int postID)
        {
            InitializeComponent();
            loadCBB();
            PostID = postID;
            ImagePathList = new List<string>();
            imageFileName = new List<string>();
            InitializePostInformation();
        }
        #region Load CBB
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
        #endregion

        public void InitializeCBB()
        {
            int addressID = (int)PostBLL.Instance.GetAddressIDByPostID(PostID);
            int districtID = AddressBLL.Instance.GetDistrictIDByAddressID(addressID);
            int wardID = AddressBLL.Instance.GetWardIDByAddressID(addressID);
            foreach (var i in cbb_District.Items)
            {
                if (((CBBItem)i).Value == districtID)
                {
                    cbb_District.SelectedItem = i;
                    break;
                }
            }
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
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
            foreach (var i in cbb_Ward.Items)
            {
                if (((CBBItem)i).Value == wardID)
                {
                    cbb_Ward.SelectedItem = i;
                    break;
                }
            }
        }
        private void InitializePostInformation()
        {
            PostViewDTO postView = PostBLL.Instance.GetPostByID(PostID);
            priceTextBox.Texts = postView.Price.ToString();
            titleTextbox.Texts = postView.Title;
            descTextbox.Texts = postView.Description;
            areaTextbox.Texts = postView.Area.ToString();
            radioButton_Rented.Checked = PostBLL.Instance.CheckRented(PostID);
            radioButton_NotRented.Checked = !PostBLL.Instance.CheckRented(PostID);
            DetailAddressTextBox.Texts = AddressBLL.Instance.GetDetailAddress(PostBLL.Instance.GetAddressIDByPostID(PostID));
            InitializeImage(postView);
            InitializeCBB();
        }

        private void InitializeImage(PostViewDTO post)
        {
            try
            {
                string imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(PostID);
                System.Drawing.Image image1;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[0]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox1.Image = image1;
                System.Drawing.Image image2;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[1]))
                {
                    image2 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox2.Image = image2;

                System.Drawing.Image image3;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[2]))
                {
                    image3 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox1.Image = image3;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
        }
        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Chọn ba ảnh!";
            opFile.Multiselect = true;
            opFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opFile.FileNames.Length != 3)
                    {
                        MessageBox.Show("Bạn phải chọn 3 ảnh!");
                        opFile.Dispose();
                        return;
                    }
                    else if (opFile.FileNames.Distinct().Count() != opFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên file ảnh phải khác nhau!");
                        opFile.Dispose();
                    }
                    IEnumerable<string> imagesIterator = opFile.FileNames.Take(3);
                    string[] images = imagesIterator.ToArray();
                    pictureBox1.Image = System.Drawing.Image.FromFile(images[0]);
                    pictureBox2.Image = System.Drawing.Image.FromFile(images[1]);
                    pictureBox3.Image = System.Drawing.Image.FromFile(images[2]);
                    for (int i = 0; i < 3; i++)
                    {
                        ImagePathList.Add(images[i]);
                        imageFileName.Add(opFile.SafeFileNames[i]);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }
        public bool checkEmpty()
        {
            if (cbb_Ward.SelectedIndex == 0 || DetailAddressTextBox.Texts == "" || titleTextbox.Texts == "" || priceTextBox.Texts == "" ||
                areaTextbox.Texts == "" || descTextbox.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }
        public bool checkFailImage()
        {
            if (ImagePathList.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh!");
                return true;
            }
            return false;
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Address addrInfo = new Address
            {
                DetailAddress = DetailAddressTextBox.Texts,
                WardID = ((CBBItem)cbb_Ward.SelectedItem).Value
            };
            //check laij nayf
            AddressBLL.Instance.UpdateAddress((int)PostBLL.Instance.GetAddressIDByPostID(PostID), addrInfo);

            Post editedPost = new Post()
            {
                PostID = this.PostID,
                UserID = LoginInfo.UserID,
                Title = titleTextbox.Texts,
                Description = descTextbox.Texts,
                Price = Convert.ToInt32(priceTextBox.Texts),
                Area = Convert.ToDouble(areaTextbox.Texts),
                BeingRented = radioButton_Rented.Checked,
                ModifiedAt = DateTime.Now
            };

            PostBLL.Instance.UpdatePost(editedPost);

            string imagePathStorage = ImageBLL.Instance.GetImageStoragePathsOfPost(PostID);
            if (ImagePathList.Count != 0)
            {
                ImageBLL.Instance.DeleteImageFromFolder(imagePathStorage);
                ImageBLL.Instance.DeleteImageFromPost(PostID);

                if (!Directory.Exists(imagePathStorage))
                    Directory.CreateDirectory(imagePathStorage);
                for (int i = 0; i < 3; i++)
                {
                    File.Copy(ImagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
                    ImageBLL.Instance.AddImage(@"\" + imageFileName[i], PostID);
                }
            }
            MessageBox.Show("Bài viết đã được cập nhật!");
            this.Close();
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

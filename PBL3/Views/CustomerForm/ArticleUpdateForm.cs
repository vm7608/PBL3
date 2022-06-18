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
            DistrictBLL.Instance.getAllDistricts().ForEach(district => cbb_District.Items.Add(district.DistrictName));
            InitializePostInformation();
        }
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
            var listDistrict = DistrictBLL.Instance.getAllDistricts();

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
                var WardInDistrict = DistrictBLL.Instance.getWardsInDistrict(districtID);
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


        //thiếu validate
        private void InitializePostInformation()
        {
            PostViewDTO postView = PostBLL.Instance.GetPostByID(PostID);
          
            priceTextbox.Text = postView.Price.ToString();
            titleTextbox.Text = postView.Title;
            descTextbox.Text = postView.Description;
            areaTextbox.Text = postView.Area.ToString();

            InitializeImage(postView);
            soNhaTextBox.Text = AddressBLL.Instance.GetDetailAddress(PostBLL.Instance.GetAddressIDByPostID(PostID));
            int? addressID = PostBLL.Instance.GetAddressIDByPostID(PostID);
            //if (addressID != null)
            //{
            //    int wardID = AddressBLL.Instance.GetWardIDByAddressID(addressID);
            //    quanComboBox.SelectedItem = DistrictBLL.Instance.GetDistrictNameByID(WardBLL.Instance.GetDistrictIDByWardID(wardID));
            //    phuongComboBox.SelectedItem = WardBLL.Instance.GetWardNameByID(wardID);
            //}

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
            opFile.Title = "Chọn ba bức hình";
            opFile.Multiselect = true;
            opFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opFile.FileNames.Length != 3)
                    {
                        MessageBox.Show("Bạn phải chọn 3 bức hình");
                        opFile.Dispose();
                        return;
                    }
                    else if (opFile.FileNames.Distinct().Count() != opFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên File phải khác nhau");
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
        
        private void updateBtn_Click(object sender, EventArgs e)
        {
            Address addrInfo = new Address
            {

            };
            //int newAddressID = AddressBLL.Instance.AddAddress(soNhaTextBox.Text, WardBLL.Instance.GetWardIDByName(cbb_Ward.SelectedItem.ToString()));
            //PostBLL.UpdatePost(PostID, newAddressID, titleTextbox.Text, descTextbox.Text,
            //                Convert.ToInt32(priceTextbox.Text), Convert.ToDouble(areaTextbox.Text));

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
            this.Close();
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

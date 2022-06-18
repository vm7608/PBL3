using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
namespace PBL3.Views.CustomerForm
{
    public partial class ArticlePostingForm : Form
    {
        private List<string> ImagePathList;
        private List<string> imageFileName;
        public ArticlePostingForm()
        {
            InitializeComponent();
            loadCBB();
            ImagePathList = new List<string>();
            imageFileName = new List<string>();
            DistrictBLL.Instance.getAllDistricts().ForEach(district => cbb_District.Items.Add(district.DistrictName));
            cbb_District.SelectedIndex = 0;
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
        private void uploadImgBtn_Click(object sender, EventArgs e)
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

        private void uploadArticleBtn_Click(object sender, EventArgs e)
        {
            if (ImagePathList.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh");
                return;
            }
            //int addressID = AddressBLL.Instance.AddAddress(soNhaTextBox.Texts, WardBLL.Instance.GetWardIDByName(phuongComboBox.SelectedItem.ToString()));
            //int postID = PostBLL.AddPost(LoginInfo.UserID, addressID, titleTextbox.Texts, descTextbox.Texts, Convert.ToInt32(priceTextBox.Texts),
            //                                                    Convert.ToDouble(areaTextbox.Texts));
            //string imagePathStorage = ImageBLL.Instance.GetImageStoragePathsOfPost(postID);
            //if (!Directory.Exists(imagePathStorage))
            //    Directory.CreateDirectory(imagePathStorage);
            //for (int i = 0; i < 3; i++)
            //{
            //    File.Copy(ImagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
            //    ImageBLL.Instance.AddImage(@"\" + imageFileName[i], postID);
            //}
            this.Close();
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}

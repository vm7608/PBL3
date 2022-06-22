using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
using System.IO;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class ImageBLL
    {
        private static MyData db;
        private static ImageBLL _Instance;
        public static ImageBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ImageBLL();
                return _Instance;
            }
            private set { }
        }
        private ImageBLL()
        {
            db = new MyData();
        }
        public List<string> GetImagePaths(int postID)
        {
            List<string> ls = new List<string>();
            //Lấy ảnh dựa trên post id
            var images = db.Images.Where(image => image.PostID == postID);
            images.ToList().ForEach(image => ls.Add(image.ImagePath));
            return ls.Take(3).ToList();
        }
        //Lấy đường dẫn của thư mục lưu trữ ảnh của người dùng có UserID
        public string GetImageStoragePathsOfPost(int? postID)
        {
            if (postID == null)
                return "";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string appPath = Path.GetFullPath(Path.Combine(path, @"..\..\"))
                + @"Resources\Post" + postID.ToString();
            return appPath;
        }
        public void AddImage(string imagePath, int postID)
        {
            Image image = new Image()
            {
                ImagePath = imagePath,
                PostID = postID
            };
            db.Images.Add(image);
            db.SaveChanges();
        }

        public void DeleteImageFromFolder(string appPath)
        {
            appPath = appPath + @"\";
            DirectoryInfo d = new DirectoryInfo(appPath);
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                File.Delete(appPath + file.Name);
            }
        }

        public void DeleteImageFromPost(int postID)
        {
            List<Image> images = db.Images.Where(i => i.PostID == postID).ToList();
            images.ForEach(image => db.Images.Remove(image));
            db.SaveChanges();
        }
    }
}

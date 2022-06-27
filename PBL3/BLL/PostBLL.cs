using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

namespace PBL3.BLL
{
    public class PostBLL
    {
        private static MyData db;
        private static PostBLL _Instance;
        public static PostBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new PostBLL();
                return _Instance;
            }
            private set { }
        }
        private PostBLL()
        {
            db = new MyData();
        }
        public void LoadApp()
        {
            db.Posts.Count();
        }
        public List<Post> SearchPost(int searchCase, int inputID, int lPrice, int rPrice, float lArea, float rArea)
        {
            List<Post> data = new List<Post>();
            switch (searchCase)
            {
                case 1:
                    data = db.Posts.Where(p => p.Price >= lPrice && p.Price <= rPrice
                    && p.Area >= lArea && p.Area <= rArea && p.BeingPosted == true).ToList();
                    break;
                case 2:
                    data = db.Posts.Where(p => p.Address.Ward.DistrictID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Area >= lArea && p.Area <= rArea && p.BeingPosted == true).ToList();
                    break;
                case 3:
                    data = db.Posts.Where(p => p.Address.Ward.WardID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Area >= lArea && p.Area <= rArea && p.BeingPosted == true).ToList();
                    break;
                default:
                    data = db.Posts.ToList();
                    break;
            }
            return data;
        }
        public List<PostViewDTO> GetSearchedPosts(int skipNum, int postNum, List<Post> data)
        {
            List<PostViewDTO> ls = new List<PostViewDTO>();
            data.OrderBy(p => p.PublishedAt).Skip(skipNum).Take(postNum)
                .ToList().ForEach(post => ls.Add(new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Area,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.Instance.GetImagePaths(post.PostID)
                }));
            return ls;
        }
        public int GetToTalNumberOfPosts()
        {
            return db.Posts.ToList().Count;
        }
        public int GetTotalNumberOfPostedPosts()
        {
            return db.Posts.Where(post => post.BeingPosted == true).ToList().Count;
        }
        public List<PostViewDTO> GetPosts(int skipNum, int postNum)
        {
            List<PostViewDTO> ls = new List<PostViewDTO>();
            db.Posts.Where(p => p.BeingPosted == true).OrderBy(post => post.PublishedAt).Skip(skipNum).Take(postNum)
                .ToList().ForEach(post => ls.Add(new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Area,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.Instance.GetImagePaths(post.PostID)
                }));
            return ls;
        }
        public PostViewDTO GetPostByID(int postID)
        {
            var post = db.Posts.FirstOrDefault(p => p.PostID == postID);
            return new PostViewDTO()
            {
                PostID = post.PostID,
                Title = post.Title,
                Description = post.Description,
                Area = post.Area,
                Price = post.Price,
                Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                UserID = post.UserID,
                ImagePaths = ImageBLL.Instance.GetImagePaths(post.PostID)
            };
        }
        public int? GetAddressIDByPostID(int postID)
        {
            return db.Posts.FirstOrDefault(p => p.PostID == postID).AddressID;
        }
        public bool CheckPosted(int postID)
        {
            return db.Posts.FirstOrDefault(p => p.PostID == postID).BeingPosted;
        }
        public bool CheckRented(int postID)
        {
            return db.Posts.FirstOrDefault(p => p.PostID == postID).BeingRented;
        }
        public void BrowsePost(int postID)
        {
            var post = db.Posts.FirstOrDefault(p => p.PostID == postID);
            post.BeingPosted = true;
            post.PublishedAt = DateTime.Now;
            db.SaveChanges();
        }
        public void DeleteUserPost(int userID)
        {
            var ls = db.Posts.Where(p => p.UserID == userID).ToList();
            ls.ForEach(post => DeletePost(post.PostID));
            db.SaveChanges();
        }
        #region CRUD post
        public int AddPost(Post newPost)
        {
            db.Posts.Add(newPost);
            db.SaveChanges();
            return newPost.PostID;
        }
        public void UpdatePost(Post editedPost)
        {
            Post post = db.Posts.FirstOrDefault(p => p.PostID == editedPost.PostID);
            post.Title = editedPost.Title;
            post.Description = editedPost.Description;
            post.Price = editedPost.Price;
            post.Area = editedPost.Area;
            post.BeingRented = editedPost.BeingRented;
            post.ModifiedAt = editedPost.ModifiedAt;
            db.SaveChanges();
        }
        public void DeletePost(int postID) //oke 
        {
            Post post = db.Posts.FirstOrDefault(p => p.PostID == postID);
            db.Posts.Remove(post);
            //xóa luôn folder chưa??
            ImageBLL.Instance.DeleteImageFromFolder(ImageBLL.Instance.GetImageStoragePathsOfPost(postID));
            db.SaveChanges();
        }
        #endregion
        #region Post management
        public dynamic GetAllPostView(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.OrderBy(post => post.PostID).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.UserID == userID).OrderBy(post => post.PostID)
                .ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }
        public dynamic GetNewestPost(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.OrderBy(post => post.CreatedAt).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.UserID == userID).OrderBy(post => post.CreatedAt)
                .ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }
        public dynamic GetPublishedPost(bool pulishedStatus, int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.BeingPosted == pulishedStatus).OrderBy(post => post.PostID).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.UserID == userID && p.BeingPosted == pulishedStatus).OrderBy(post => post.PostID)
                .ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }
        public dynamic GetRentedPost(bool rentedStatus, int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.BeingRented == rentedStatus).OrderBy(post => post.PostID).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.UserID == userID && p.BeingRented == rentedStatus).OrderBy(post => post.PostID)
                .ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Area,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }
        #endregion
        public string GetPublishedTime(int postID)
        {
            var p = db.Posts.FirstOrDefault(post => post.PostID == postID);
            string datetime = p.PublishedAt.ToString();
            return datetime;
        }

    }
}


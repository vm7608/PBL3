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
        #region Singleton Pattern
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
        #endregion
        public void LoadApp()
        {
            //tác động lên db để thao tác ban đầu mượt hơn
            db.Posts.Count();
        }
        public int GetToTalNumberOfPosts()
        {
            return db.Posts.ToList().Count;
        }
        public int GetTotalNumberOfPostedPosts()
        {
            return db.Posts.Where(post => post.BeingPosted == true).ToList().Count;
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
        public string GetPublishedTime(int postID)
        {
            var p = db.Posts.FirstOrDefault(post => post.PostID == postID);
            string datetime = p.PublishedAt.ToString();
            return datetime;
        }
        public int GetNumOfCommentInPost(int postID)
        {
            var data = db.Comments.Where(p => p.PostID == postID).ToList();
            if (data == null) return 0;
            return data.Count();
        }
        #region Search on Dashboard
        public List<Post> SearchPost(int searchCase, int inputID, int lPrice, int rPrice, float lArea, float rArea)
        {
            List<Post> data = new List<Post>();
            switch (searchCase)
            {
                case 1:
                    data = db.Posts.Where(p => p.Price >= lPrice && p.Price <= rPrice
                    && p.Area >= lArea && p.Area <= rArea && p.BeingPosted == true && p.BeingRented == false).ToList();
                    break;
                case 2:
                    data = db.Posts.Where(p => p.Address.Ward.DistrictID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Area >= lArea && p.Area <= rArea
                    && p.BeingPosted == true && p.BeingRented == false).ToList();
                    break;
                case 3:
                    data = db.Posts.Where(p => p.Address.Ward.WardID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Area >= lArea && p.Area <= rArea
                    && p.BeingPosted == true && p.BeingRented == false).ToList();
                    break;
                default:
                    data = db.Posts.Where(p => p.BeingPosted == true && p.BeingRented == false).ToList();
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
        public List<PostViewDTO> GetSortedPosts(int skipNum, int postNum, List<Post> data, int sortCase)
        {
            List<PostViewDTO> ls = new List<PostViewDTO>();
            List<Post> sorted = new List<Post>();
            switch(sortCase)
            {
                case 0: //Mới nhất
                    sorted = data.OrderByDescending(p => p.PublishedAt).Skip(skipNum).Take(postNum).ToList();
                    break;
                case 1: //Cũ nhất
                    sorted = data.OrderBy(p => p.PublishedAt).Skip(skipNum).Take(postNum).ToList();
                    break;
                case 2: //Giá từ thấp đến cao
                    sorted = data.OrderBy(p => p.Price).Skip(skipNum).Take(postNum).ToList();
                    break;
                case 3: //Giá từ cao đến thấp
                    sorted = data.OrderByDescending(p => p.Price).Skip(skipNum).Take(postNum).ToList();
                    break;
                case 4: //Diện tích từ nhỏ đến lớn
                    sorted = data.OrderBy(p => p.Area).Skip(skipNum).Take(postNum).ToList();
                    break;
                case 5: //Diện tích từ lớn đến nhỏ
                    sorted = data.OrderByDescending(p => p.Area).Skip(skipNum).Take(postNum).ToList();
                    break;
                default:
                    sorted = data.OrderByDescending(p => p.PublishedAt).Skip(skipNum).Take(postNum).ToList();
                    break;
            }
            foreach(var post in sorted)
            {
                ls.Add(new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Area,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.Instance.GetImagePaths(post.PostID)
                });
            }
            return ls;
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
        #endregion
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
        public void DeletePost(int postID)
        {
            Post post = db.Posts.FirstOrDefault(p => p.PostID == postID);
            db.Posts.Remove(post);
            //xóa luôn folder chưa??
            ImageBLL.Instance.DeleteImageFromFolder(ImageBLL.Instance.GetImageStoragePathsOfPost(postID));
            db.SaveChanges();
        }
        #endregion
        #region Post management DTG
        public List<PostDTGViewDTO> GetDTGView(int searchFilter, int sortCase, bool checkAscending, string searchChars, int userID = -1)
        {
            List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
            switch (searchFilter)
            {
                case 0: //Tất cả bài đăng
                    data = PostBLL.Instance.GetAllPostView(userID);
                    break;
                case 1: //Bài đăng đã được duyệt
                    data = PostBLL.Instance.GetPublishedPost(true, userID);
                    break;
                case 2: //Bài đăng chưa được duyệt
                    data = PostBLL.Instance.GetPublishedPost(false, userID);
                    break;
                case 3: //Bài đăng đã cho thuê
                    data = PostBLL.Instance.GetRentedPost(true, userID);
                    break;
                case 4: //Bài đăng chưa cho thuê
                    data = PostBLL.Instance.GetRentedPost(false, userID);
                    break;
                case 5: //Bài đăng đã chỉnh sửa
                    data = PostBLL.Instance.GetEditedPost(userID);
                    break;
                default:
                    data = PostBLL.Instance.GetAllPostView();
                    break;
            }
            List<PostDTGViewDTO> temp = new List<PostDTGViewDTO>();
            temp = PostBLL.Instance.SearchByChars(searchChars, data);
            List<PostDTGViewDTO> result = new List<PostDTGViewDTO>();
            result = PostBLL.Instance.SortResult(sortCase, checkAscending, temp);
            return result;
        }
        public List<PostDTGViewDTO> SearchByChars(string searchChar, List<PostDTGViewDTO> data)
        {
            List<PostDTGViewDTO> result = new List<PostDTGViewDTO>();
            foreach (var i in data)
            {
                if(i.Username.Contains(searchChar) || i.Title.Contains(searchChar) || i.Address.Contains(searchChar))
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<PostDTGViewDTO> SortResult(int sortCase, bool checkAscending, List<PostDTGViewDTO> data)
        {
            List<PostDTGViewDTO> result = new List<PostDTGViewDTO>();
            switch (sortCase)
            {
                case 0: //Thời gian tạo
                    result = data.OrderBy(p => p.CreatedAt).ToList();
                    break;
                case 1: //num of cmt
                    result = data.OrderBy(p => p.NumberOfComment).ToList();
                    break;
                case 2: //rating
                    result = data.OrderBy(p => p.AvgRating).ToList();
                    break;
                default: //Time
                    result = data.OrderBy(p => p.CreatedAt).ToList();
                    break;
            }
            if(!checkAscending)
            {
                result.Reverse(); //check lai
            }
            return result;
        }
        public dynamic GetAllPostView(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.UserID == userID).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
        }
        public dynamic GetPublishedPost(bool pulishedStatus, int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.BeingPosted == pulishedStatus).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.UserID == userID && p.BeingPosted == pulishedStatus).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
        }
        public dynamic GetRentedPost(bool rentedStatus, int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.BeingRented == rentedStatus).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.UserID == userID && p.BeingRented == rentedStatus).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
        }
        public dynamic GetEditedPost(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.ModifiedAt != null).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                List<PostDTGViewDTO> data = new List<PostDTGViewDTO>();
                db.Posts.Where(p => p.UserID == userID && p.ModifiedAt != null).ToList().ForEach(post => data.Add(new PostDTGViewDTO
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Username = UserBLL.Instance.GetUserFullname(post.UserID),
                    Title = post.Title,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    AvgRating = RatingBLL.Instance.GetPostRating(post.PostID),
                    NumberOfComment = PostBLL.Instance.GetNumOfCommentInPost(post.PostID),
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented,
                    CreatedAt = post.CreatedAt,
                    PublishedAt = post.PublishedAt,
                    ModifiedAt = post.ModifiedAt
                }));
                return data;
            }
        }
        #endregion
    }
}


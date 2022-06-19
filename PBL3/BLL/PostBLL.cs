﻿using System;
using System.Collections.Generic;
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
        public dynamic GetPostByUserID(int UserID)
        {
            return db.Posts.Where(p => p.UserID == UserID).ToList();
        }
        public dynamic GetAllPost()
        {
            return db.Posts.ToList();
        }
        public List<Post> searchPost(int searchCase, int inputID, int lPrice, int rPrice, float lSquare, float rSquare)
        {
            List<Post> data = new List<Post>();
            switch (searchCase)
            {
                case 1:
                    data = db.Posts.Where(p => p.Price >= lPrice && p.Price <= rPrice
                    && p.Square >= lSquare && p.Square <= rSquare && p.BeingPosted == true).ToList();
                    break;
                case 2:
                    data = db.Posts.Where(p => p.Address.Ward.DistrictID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Square >= lSquare && p.Square <= rSquare && p.BeingPosted == true).ToList();
                    break;
                case 3:
                    data = db.Posts.Where(p => p.Address.Ward.WardID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.Square >= lSquare && p.Square <= rSquare && p.BeingPosted == true).ToList();
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

            data.OrderByDescending(p => p.PublishedAt).Skip(skipNum).Take(postNum)
                .ToList().ForEach(post => ls.Add(new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Square,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.GetImagePaths(post.PostID)
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

            db.Posts.Where(p => p.BeingPosted == true).OrderByDescending(post => post.PublishedAt).Skip(skipNum).Take(postNum)
                .ToList().ForEach(post => ls.Add(new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Square,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.GetImagePaths(post.PostID)
                }));
            return ls;

        }

        public PostViewDTO GetPostByID(int postID)
        {

            var post = db.Posts.Where(p => p.PostID == postID).FirstOrDefault();
            return new PostViewDTO()
            {
                PostID = post.PostID,
                Title = post.Title,
                Description = post.Description,
                Area = post.Square,
                Price = post.Price,
                Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                UserID = post.UserID,
                ImagePaths = ImageBLL.GetImagePaths(post.PostID)
            };

        }
        public int? GetAddressIDByPostID(int postID)
        {
            return db.Posts.Where(p => p.PostID == postID).FirstOrDefault().AddressID;
        }

        public bool CheckPosted(int postID)
        {
            return db.Posts.Where(p => p.PostID == postID).FirstOrDefault().BeingPosted;
        }

        public void BrowsePost(int postID)
        {
            var post = db.Posts.Where(p => p.PostID == postID).FirstOrDefault();
            post.BeingPosted = true;
            db.SaveChanges();
        }

        #region CRUD post
        public int AddPost(int userID, int addressID, string title, string description, int price, float area)
        {

            Post post = new Post()
            {
                UserID = userID,
                AddressID = addressID,
                Title = title,
                Description = description,
                Price = price,
                Square = area,
                BeingPosted = false,
                BeingRented = false,
                CreatedAt = DateTime.Now
            };
            db.Posts.Add(post);
            db.SaveChanges();
            return post.PostID;

        }
        public void UpdatePost(int postID, int newAddressID, string title, string desc, int price, float area)
        {

            Post post = db.Posts.Where(p => p.PostID == postID).FirstOrDefault();
            post.AddressID = newAddressID;
            post.Title = title;
            post.Description = desc;
            post.Price = price;
            post.Square = area;
            db.SaveChanges();

        }

        public void DeletePost(int postID) //oke 
        {
            Post post = db.Posts.Where(p => p.PostID == postID).FirstOrDefault();
            db.Posts.Remove(post);
            //xóa luôn folder chưa??
            ImageBLL.Instance.DeleteImageFromFolder(ImageBLL.Instance.GetImageStoragePathsOfPost(postID));
            RatingBLL.Instance.DeleteStarByPostID(postID);
            CommentBLL.Instance.DeleteCommentInPost(postID);
            db.SaveChanges();
        }
        #endregion
        #region Post management
        public dynamic getAllPostView(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.OrderBy(post => post.PostID).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Square,
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
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Square,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }

        public dynamic getNewestPost(int userID = -1)
        {
            if (userID == -1) //get tất cả post trong hệ thống
            {
                var data = new List<dynamic>();
                db.Posts.OrderByDescending(post => post.CreatedAt).ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    UserID = post.UserID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Square,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
            else //get post của host đang đăng nhập
            {
                var data = new List<dynamic>();
                db.Posts.Where(p => p.UserID == userID).OrderByDescending(post => post.CreatedAt)
                .ToList().ForEach(post => data.Add(new
                {
                    PostID = post.PostID,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    Title = post.Title,
                    Description = post.Description,
                    Price = post.Price,
                    Area = post.Square,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }

        public dynamic getPublishedPost(bool pulishedStatus, int userID = -1)
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
                    Area = post.Square,
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
                    Area = post.Square,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }

        public dynamic getRentedPost(bool rentedStatus, int userID = -1)
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
                    Area = post.Square,
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
                    Area = post.Square,
                    CreatedAt = post.CreatedAt,
                    Posted = post.BeingPosted,
                    Rented = post.BeingRented
                }));
                return data;
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class RatingBLL
    {
        private static MyData db;
        private static RatingBLL _Instance;
        public static RatingBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new RatingBLL();
                return _Instance;
            }
            private set { }
        }
        private RatingBLL()
        {
            db = new MyData();
        }
        public  void AddRating(int userID, int postID, int starNums)
        {
            using (var context = new MyData())
            {
                Rating rating = new Rating()
                {
                    UserID = userID,
                    PostID = postID,
                    Star = starNums,
                    CreatedAt = DateTime.Now
                };
                context.Ratings.Add(rating);
                context.SaveChanges();
            }
        }

        public  bool CheckRating(int userID, int postID)
        {
            using (var context = new MyData())
            {
                var rating = context.Ratings
                    .Where(r => r.UserID == userID && r.PostID == postID).FirstOrDefault();
                if (rating == null)
                    return false;
                else
                    return true;
            }
        }

        public  int GetStars(int userID, int postID)
        {
            using (var context = new MyData())
            {
                return context.Ratings.Where(c => c.UserID == userID && c.PostID == postID).FirstOrDefault().Star;
            }
        }
        public void DeleteStarByPostID(int postID)
        {
            using (var context = new MyData())
            {
                List<Rating> ls = context.Ratings.Where(r => r.PostID == postID).ToList();
                ls.ForEach(rating => context.Ratings.Remove(rating));
            }
        }

        public void DeleteUserRating(int userID)
        {
            using (var context = new MyData())
            {
                List<Rating> ls = context.Ratings.Where(r => r.UserID == userID).ToList();
                ls.ForEach(rating => context.Ratings.Remove(rating));
            }
        }
        public int GetNumberOfRatings(int postID)
        {
            using (var context = new MyData())
            {
                return context.Ratings.ToList().Count;
            }
        }

        public int GetPostRating(int postID)
        {
            using (var context = new MyData())
            {
                return context.Ratings.Where(r => r.PostID == postID)
                        .ToList().Sum(r => r.Star) / GetNumberOfRatings(postID);
            }
        }
    }
}

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
        public void AddRating(int userID, int postID, int starNums)
        {
            Rating rating = new Rating()
            {
                UserID = userID,
                PostID = postID,
                Star = starNums,
                CreatedAt = DateTime.Now
            };
            db.Ratings.Add(rating);
            db.SaveChanges();
        }
        public bool CheckRating(int userID, int postID)
        {
            var rating = db.Ratings
                .Where(r => r.UserID == userID && r.PostID == postID).FirstOrDefault();
            if (rating == null)
                return false;
            else
                return true;
        }
        public int GetStars(int userID, int postID)
        {
            return db.Ratings.Where(c => c.UserID == userID && c.PostID == postID).FirstOrDefault().Star;
        }
        public double GetPostRating(int postID)
        {
            if (db.Ratings.Where(r => r.PostID == postID).ToList().Count == 0) return 0;
            return db.Ratings.Where(r => r.PostID == postID).ToList().Average(r => r.Star);
        }
        public void DeleteUserRatingInPost(int userID, int postID)
        {
            var rating = db.Ratings.Where(r => r.UserID == userID && r.PostID == postID).FirstOrDefault();
            db.Ratings.Remove(rating);
            db.SaveChanges();
        }
    }
}

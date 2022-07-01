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
        #region ->Singleton Pattern
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
        #endregion

        public int GetStars(int userID, int postID)
        {
            return db.Ratings.FirstOrDefault(c => c.UserID == userID && c.PostID == postID).Star;
        }
        public double GetPostRating(int postID)
        {
            //trả về rating trung bình của post
            if (db.Ratings.Where(r => r.PostID == postID).ToList().Count == 0) return 0;
            return db.Ratings.Where(r => r.PostID == postID).ToList().Average(r => r.Star);
        }
        public bool CheckRating(int userID, int postID)
        {
            //check một user đã rating cho post chưa
            var rating = db.Ratings
                            .FirstOrDefault(r => r.UserID == userID && r.PostID == postID);
            if (rating == null)
                return false;
            else
                return true;
        }

        #region ->Add/Delete rating
        public void AddRating(int userID, int postID, int starNums)
        {
            Rating rating = new Rating()
            {
                UserID = userID,
                PostID = postID,
                Star = starNums
            };
            db.Ratings.Add(rating);
            db.SaveChanges();
        }
        public void DeleteUserRatingInPost(int userID, int postID)
        {
            var rating = db.Ratings.FirstOrDefault(r => r.UserID == userID && r.PostID == postID);
            db.Ratings.Remove(rating);
            db.SaveChanges();
        }
        #endregion
    }
}

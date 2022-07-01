using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

namespace PBL3.BLL
{
    public class CommentBLL
    {
        #region ->Singleton Pattern
        private static MyData db;
        private static CommentBLL _Instance;
        public static CommentBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CommentBLL();
                return _Instance;
            }
            private set { }
        }
        private CommentBLL()
        {
            db = new MyData();
        }
        #endregion

        public int GetNumberOfComments(int postID)
        {
            return db.Comments.Where(c => c.PostID == postID).ToList().Count;
        }
        public List<CommentViewDTO> GetCommentsView(int postID, int skipNum, int commentNum)
        {
            //Hàm lấy thông tin để hiển thị comment dưới bài post
            //Hiển thị comment mới nhất lên trước
            List<CommentViewDTO> ls = new List<CommentViewDTO>();
            db.Comments.Where(c => c.PostID == postID).OrderByDescending(c => c.CreatedAt)
                .Skip(skipNum).Take(commentNum).ToList()
                .ForEach(c =>
                {
                    ls.Add(new CommentViewDTO()
                    {
                        Content = c.Content,
                        UserID = c.UserID,
                        CommentID = c.CommentID
                    });
                });
            return ls;
        }
        public int GetUserIDByCommentID(int commentID)
        {
            var cmt = db.Comments.Where(c => c.CommentID == commentID).FirstOrDefault();
            if (cmt == null) return -1;
            else return cmt.UserID;
        }

        #region ->Add/Update/Delete Comments
        public void AddComment(int userID, int postID, string content)
        {
            Comment comment = new Comment()
            {
                Content = content,
                UserID = userID,
                PostID = postID,
                CreatedAt = DateTime.Now,
            };
            db.Comments.Add(comment);
            db.SaveChanges();
        }
        public void UpdateComment(int commentID, string content)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentID == commentID);
            comment.Content = content;
            db.SaveChanges();
        }
        public void DeleteCommentByID(int commentID)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentID == commentID);
            db.Comments.Remove(comment);
            db.SaveChanges();
        }
        public void DeleteUserComment(int userID)
        {
            List<Comment> ls = db.Comments.Where(c => c.UserID == userID).ToList();
            ls.ForEach(comment => db.Comments.Remove(comment));
        }
        #endregion
    }
}

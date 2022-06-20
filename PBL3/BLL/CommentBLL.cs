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
        public void AddComment(int userID, int postID, string content)
        {
            using (var context = new MyData())
            {
                Comment comment = new Comment()
                {
                    Content = content,
                    UserID = userID,
                    PostID = postID
                };
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
        public List<CommentViewDTO> GetCommentsByPostID(int postID)
        {
            using (var context = new MyData())
            {
                List<CommentViewDTO> ls = new List<CommentViewDTO>();
                context.Comments
                    .Where(c => c.PostID == postID)
                    .ToList().ForEach(c => ls.Add(new CommentViewDTO()
                    {
                        Content = c.Content,
                        UserID = c.UserID
                    }));
                return ls;
            }
        }

        public int GetNumberOfComments(int postID)
        {
            using (var context = new MyData())
            {
                return context.Comments.Where(c => c.PostID == postID).ToList().Count;
            }
        }
        public List<CommentViewDTO> GetComments(int postID, int skipNum, int commentNum)
        {
            using (var context = new MyData())
            {
                List<CommentViewDTO> ls = new List<CommentViewDTO>();
                context.Comments.Where(c => c.PostID == postID).OrderBy(c => c.PostID)
                    .Skip(skipNum).Take(commentNum).ToList()
                    .ForEach(c =>
                    {
                        ls.Add(new CommentViewDTO()
                        {
                            Content = c.Content,
                            UserID = c.UserID
                        });
                    });
                return ls;
            }
        }

        public void DeleteUserComment(int userID)
        {
            using (var context = new MyData())
            {
                List<Comment> ls = context.Comments.Where(c => c.UserID == userID).ToList();
                ls.ForEach(comment => context.Comments.Remove(comment));
            }
        }
    }
}

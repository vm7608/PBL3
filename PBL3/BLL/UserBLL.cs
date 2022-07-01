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
    public class UserBLL
    {
        #region ->Singleton Pattern
        private static MyData db;
        private static UserBLL _Instance;
        public static UserBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UserBLL();
                return _Instance;
            }
            private set { }
        }
        private UserBLL()
        {
            db = new MyData();
        }
        #endregion

        public int GetAddressIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AddressID;
        }
        public int GetUserIDByAccountID(int accountId)
        {
            var user = db.Users.FirstOrDefault(p => p.AccountID == accountId);
            if (user != null)
            {
                return user.UserID;
            }
            return -1;
        }
        public User GetUserByID(int? userID)
        {
            if (userID == null)
                return null;
            return db.Users.FirstOrDefault(u => u.UserID == userID);
        }
        public int GetAccountIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AccountID;
        }
        public string GetUserFullname(int? userID)
        {
            if (userID == null) return "";
            return db.Users.FirstOrDefault(user => user.UserID == userID).FullName;
        }
        public int CountUserPost(int userID)
        {
            var userpost = db.Posts.Where(p => p.UserID == userID).ToList();
            if (userpost == null) return 0;
            else
            {
                return userpost.Count();
            }
        }
        public int CountUserCMT(int userID)
        {
            var usercmt = db.Comments.Where(c => c.UserID == userID).ToList();
            if (usercmt == null) return 0;
            else
            {
                return usercmt.Count();
            }
        }

        #region ->User DTG Management
        public List<UserViewDTO> SearchUser(string searchChars, string rolename, int sortCase, bool checkAscending)
        {
            List<UserViewDTO> data = new List<UserViewDTO>();
            db.Users.Where(u => u.Account.RoleID == 2 || u.Account.RoleID == 3).ToList().ForEach(u => data.Add(new UserViewDTO
            {
                UserID = u.UserID,
                Rolename = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                Fullname = u.FullName,
                Email = u.Email,
                Phone = u.Phone,
                Address = AddressBLL.Instance.GetFullAddress(u.AddressID),
                NumberOfPost = UserBLL.Instance.CountUserPost(u.UserID),
                NumberOfComment = UserBLL.Instance.CountUserCMT(u.UserID),
                JoinedAt = u.Account.CreatedAt
            }));
            //Sau khi get ra, search theo char + rolename và sort lại kết quả 
            List<UserViewDTO> temp = UserBLL.Instance.SearchCharsAndRoleName(searchChars, rolename, data);
            List<UserViewDTO> result = UserBLL.Instance.SortResult(sortCase, checkAscending, temp);
            return result;
        }
        public List<UserViewDTO> SearchCharsAndRoleName(string searchChars, string rolename, List<UserViewDTO> data)
        {
            //Sau khi search theo filter, lọc các kết quả chứa char và có rolename cần tìm
            List<UserViewDTO> result = new List<UserViewDTO>();
            if (rolename == "All")
            {
                foreach (var i in data)
                {
                    if (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
            else
            {
                foreach (var i in data)
                {
                    if ((i.Rolename == rolename) && (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars)))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
        }
        public List<UserViewDTO> SortResult(int sortCase, bool checkAscending, List<UserViewDTO> data)
        {
            List<UserViewDTO> result = new List<UserViewDTO>();
            switch (sortCase)
            {
                case 0: // Thời gian tham gia
                    result = data.OrderBy(p => p.JoinedAt).ToList();
                    break;
                case 1: // Số bài post
                    result = data.OrderBy(p => p.NumberOfPost).ToList();
                    break;
                case 2: //Số comment
                    result = data.OrderBy(p => p.NumberOfComment).ToList();
                    break;
            }
            if(!checkAscending)
            {
                //sort descending
                result.Reverse();
            }
            return result;
        }
        #endregion

        #region ->Add/Update/Delete User
        public int AddUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser.UserID;
        }
        public void UpdateUserInformation(User userInfo, Address addInfo)
        {
            User user = db.Users.FirstOrDefault(u => u.UserID == userInfo.UserID);
            user.FullName = userInfo.FullName;
            user.Phone = userInfo.Phone;
            user.Email = userInfo.Email;
            AddressBLL.Instance.UpdateAddress(user.AddressID, addInfo);
            db.SaveChanges();
        }
        public void DeleteUser(int userID)
        {
            //Đầu tiên là xóa post, sau đó xóa account và address
            //Các dữ liệu theo các key phụ thuộc giữa các bảng sẽ bị xóa theo
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            PostBLL.Instance.DeleteUserPost(user.UserID);
            AccountBLL.Instance.DeleteAccount(user.AccountID);
            AddressBLL.Instance.DeleteAddress(user.AddressID);
            db.SaveChanges();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class UserBLL
    {
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
        public dynamic GetAllUser()
        {
            return db.Users.ToList();
        }
        public int GetUserIDByAccountID(int accountId)
        {
            var user = db.Users.Where(p => p.AccountID == accountId).FirstOrDefault();
            if (user != null)
            {
                return user.UserID;
            }
            return -1;

        }
        public int AddUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser.UserID;

        }

        public User GetUserByID(int? userID)
        {
            if (userID == null)
                return null;
            return db.Users.Where(u => u.UserID == userID).FirstOrDefault();
        }
        public int GetAccountIDByUserID(int userID)
        {
            return db.Users.Where(user => user.UserID == userID).FirstOrDefault().AccountID;
        }

        public void DeleteUser(int userID)
        {
            var user = db.Users.Where(u => u.UserID == userID).FirstOrDefault();
            PostBLL.Instance.DeleteUserPost(user.UserID);
            AccountBLL.Instance.DeleteAccount(user.AccountID);
            AddressBLL.Instance.DeleteAddress(user.AddressID);
            db.SaveChanges();
        }

        //nhieu ref
        public string GetUserFullname(int userID)
        {
            return db.Users.Where(user => user.UserID == userID).FirstOrDefault().FullName;
        }

        public void UpdateUserInformation(User userInfo, Address addInfo)
        {
            User user = db.Users.Where(u => u.UserID == userInfo.UserID).FirstOrDefault();
            user.FullName = userInfo.FullName;
            user.Phone = userInfo.Phone;
            user.Email = userInfo.Email;
            AddressBLL.Instance.UpdateAddress(user.AddressID, addInfo);
            db.SaveChanges();
        }

        public string GetContactInformation(int userID)
        {
            return db.Users.Where(user => user.UserID == userID)
                        .FirstOrDefault().Phone;
        }
        public string GetNameInformation(int userID)
        {
            return db.Users.Where(user => user.UserID == userID)
                        .FirstOrDefault().FullName;
        }
    }
}

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
            var data = new List<dynamic>();
            db.Users.Where(u => u.Account.RoleID == 2 || u.Account.RoleID == 3).ToList().ForEach(u => data.Add(new
            {
                UserID = u.UserID,
                RoleName = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                Fullname = u.FullName,
                Email = u.Email,
                Phone = u.Phone,
                Address = AddressBLL.Instance.GetFullAddress(u.AddressID)
            }));
            return data;
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
        public dynamic Search(int filter, string searchChars, string rolename)
        {
            return SearchRole(SearchUser(filter, searchChars), rolename);
        }
        public dynamic SearchRole(List<dynamic> data, string rolename)
        {
            var result = new List<dynamic>();
            if (rolename == "All")
            {
                return data;
            }
            else
            {
                foreach (var i in data)
                {
                    if (i.RoleName == rolename)
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
        }
        public dynamic SearchUser(int filter, string searchChars)
        {
            var data = new List<dynamic>();
            switch (filter)
            {
                case 0: //name
                    db.Users.Where(u => u.FullName.Contains(searchChars) && (u.Account.RoleID == 2 || u.Account.RoleID == 3)).ToList().ForEach(u => data.Add(new
                    {
                        UserID = u.UserID,
                        RoleName = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                        Fullname = u.FullName,
                        Email = u.Email,
                        Phone = u.Phone,
                        Address = AddressBLL.Instance.GetFullAddress(u.AddressID)
                    }));
                    break;
                case 1: //phone
                    db.Users.Where(u => u.Phone.Contains(searchChars) && (u.Account.RoleID == 2 || u.Account.RoleID == 3)).ToList().ForEach(u => data.Add(new
                    {
                        UserID = u.UserID,
                        RoleName = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                        Fullname = u.FullName,
                        Email = u.Email,
                        Phone = u.Phone,
                        Address = AddressBLL.Instance.GetFullAddress(u.AddressID)
                    }));
                    break;
                case 2: //email
                    db.Users.Where(u => u.Email.Contains(searchChars) && (u.Account.RoleID == 2 || u.Account.RoleID == 3)).ToList().ForEach(u => data.Add(new
                    {
                        UserID = u.UserID,
                        RoleName = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                        Fullname = u.FullName,
                        Email = u.Email,
                        Phone = u.Phone,
                        Address = AddressBLL.Instance.GetFullAddress(u.AddressID)
                    }));
                    break;
                default:
                    break;
            }
            return data;
        }
    }
}

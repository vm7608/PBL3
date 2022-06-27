using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class AccountBLL
    {
        private static MyData db;
        private static AccountBLL _Instance;
        public static AccountBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AccountBLL();
                return _Instance;
            }
            private set { }
        }
        private AccountBLL()
        {
            db = new MyData();
        }
        public int GetRoleByAccountID(int accID)
        {
            var acc = db.Accounts.FirstOrDefault(p => p.AccountID == accID);
            if (acc != null)
                return acc.RoleID;
            else
                return 0;
        }
        public string GetRoleNameByAccountID(int accID)
        {
            var acc = db.Accounts.FirstOrDefault(p => p.AccountID == accID);
            if (acc != null)
                return acc.Role.RoleName;
            else
                return "";
        }
        public int GetRole(string username, string password)
        {
            foreach(var account in db.Accounts){
                if (account.Username == username
                     && PasswordHashing.DecodePasswordFromBase64(account.Password) == password)
                    return account.RoleID;
            }
            return 0;
        }

        public int GetAccountID(string username, string password)
        {
            foreach (var account in db.Accounts)
            {
                if (account.Username == username
                     && PasswordHashing.DecodePasswordFromBase64(account.Password) == password)
                    return account.AccountID;
            }
            return -1;
        }
        public bool CheckExistingUsername(string username)
        {
            return db.Accounts.Any(p => p.Username == username);
        }
        public bool CheckPassword(int accountID, string password)
        {
            foreach (var account in db.Accounts)
            {
                if (account.AccountID == accountID && 
                    PasswordHashing.DecodePasswordFromBase64(account.Password) == password)
                    return true;
            }
            return false;
        }
        public void ChangePassword(int accountID, string newPassword)
        {
            Account acc = null;
            foreach (var account in db.Accounts)
            {
                if (acc.AccountID == accountID)
                {
                    acc = account;
                    break;
                }
            }
            acc.Password = PasswordHashing.EncodePasswordToBase64(newPassword);
            acc.ModifiedAt = DateTime.Now;
            db.SaveChanges();
        }
        public int AddAccount(Account newAccount)
        {
            db.Accounts.Add(newAccount);
            db.SaveChanges();
            return newAccount.AccountID;
        }
        public void DeleteAccount(int accountID)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }
    }
}

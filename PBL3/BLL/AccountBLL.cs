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
        #region ->Singleton Pattern
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
        #endregion

        public string GetRoleNameByAccountID(int accID)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.AccountID == accID);
            if (acc != null)
            {
                if (acc.RoleID == 2) return "Người cho thuê";
                if (acc.RoleID == 3) return "Người thuê";
                return "Quản trị viên";
            }
            else
                return "";
        }
        public int GetRoleIDByAccountID(int accountID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accountID).RoleID;
        }
        public int GetRole(string username, string password)
        {
            foreach (var account in db.Accounts)
            {
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

        #region ->Change Pass and Add/Delete Account
        public void ChangePassword(int accountID, string newPassword)
        {
            Account acc = db.Accounts.Where(a => a.AccountID == accountID).FirstOrDefault();
            acc.Password = PasswordHashing.EncodePasswordToBase64(newPassword);
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
        #endregion
    }
}

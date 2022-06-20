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
        public int GetRole(string username, string password)
        {
            var acc = db.Accounts.Where(account => account.Username == username && account.Password == password).FirstOrDefault<Account>();
            if (acc != null)
                return acc.RoleID;
            else
                return 0;
        }

        public int GetAccountID(string username, string password)
        {
            var account = db.Accounts.Where(acc => acc.Username == username && acc.Password == password).FirstOrDefault();
            if (account != null)
                return account.AccountID;
            else
                return -1;
        }

        public bool CheckExistingUsername(string username)
        {
            return db.Accounts.Any(p => p.Username == username);
               
        }

        public bool CheckPassword(int accountID, string password)
        {
            var acc = db.Accounts.Where(account => account.AccountID == accountID).FirstOrDefault();
            if (acc.Password == password)
                return true;
            else
                return false;
        }

        public void ChangePassword(int accountID, string newPassword)
        {
            var acc = db.Accounts.Where(account => account.AccountID == accountID).FirstOrDefault();
            acc.Password = newPassword;
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
            var acc = db.Accounts.Where(a => a.AccountID == accountID).FirstOrDefault();
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }
    }
}

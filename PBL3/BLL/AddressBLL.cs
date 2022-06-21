using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class AddressBLL
    {
        private static MyData db;
        private static AddressBLL _Instance;
        public static AddressBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AddressBLL();
                return _Instance;
            }
            private set { }
        }
        private AddressBLL()
        {
            db = new MyData();
        }

        public int AddAddress(Address newAddress)
        {
            db.Addresses.Add(newAddress);
            db.SaveChanges();
            return newAddress.AddressID;
        }
        public string GetFullAddress(int? addressID)
        {
            if (addressID == null)
                return "";
            Address addr = db.Addresses.Where(p => p.AddressID == addressID).FirstOrDefault();
            Ward ward = db.Wards.Where(p => p.WardID == addr.WardID).FirstOrDefault();
            District dis = db.Districts.Where(p => p.DistrictID == ward.DistrictID).FirstOrDefault();
            string fullAddress = addr.DetailAddress + ", " + ward.WardName + ", " + dis.DistrictName;
            return fullAddress;
        }

        public void UpdateAddress(int addressID, Address addInfo)
        {
            Address address = db.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
            address.WardID = addInfo.WardID;
            address.DetailAddress = addInfo.DetailAddress;
            db.SaveChanges();
        }

        public string GetDetailAddress(int? addressID)
        {
            return db.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault().DetailAddress;
        }
        public int GetWardIDByAddressID(int? addressID)
        {
            if (addressID == null) return 0;
            var addr = db.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
            if (addr == null) return 0;
            else
            {
                return addr.WardID;
            }
        }
        public int GetDistrictIDByAddressID(int? addressID)
        {
            if (addressID == null) return 0;
            var addr = db.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
            if (addr == null) return 0;
            else
            {
                var ward = WardBLL.Instance.getWardByWardID(addr.WardID);
                return ward.DistrictID;
            }
        }

        public void DeleteAddress(int? addressID)
        {
            var addr = db.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
            db.Addresses.Remove(addr);
            db.SaveChanges();
        }
    }
}

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
            Address addr = db.Addresses.FirstOrDefault(p => p.AddressID == addressID);
            Ward ward = db.Wards.FirstOrDefault(p => p.WardID == addr.WardID);
            District dis = db.Districts.FirstOrDefault(p => p.DistrictID == ward.DistrictID);
            string fullAddress = addr.DetailAddress + ", " + ward.WardName + ", " + dis.DistrictName;
            return fullAddress;
        }
        public void UpdateAddress(int addressID, Address addInfo)
        {
            Address address = db.Addresses.FirstOrDefault(a => a.AddressID == addressID);
            address.WardID = addInfo.WardID;
            address.DetailAddress = addInfo.DetailAddress;
            db.SaveChanges();
        }
        public string GetDetailAddress(int? addressID)
        {
            return db.Addresses.FirstOrDefault(a => a.AddressID == addressID).DetailAddress;
        }
        public int GetWardIDByAddressID(int? addressID)
        {
            if (addressID == null) return 0;
            var addr = db.Addresses.FirstOrDefault(a => a.AddressID == addressID);
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
                var ward = WardBLL.Instance.GetWardByWardID(addr.WardID);
                return ward.DistrictID;
            }
        }
        public void DeleteAddress(int? addressID)
        {
            var addr = db.Addresses.FirstOrDefault(a => a.AddressID == addressID);
            db.Addresses.Remove(addr);
            db.SaveChanges();
        }
    }
}

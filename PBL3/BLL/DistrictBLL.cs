using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class DistrictBLL
    {
        private static MyData db;
        private static DistrictBLL _Instance;
        public static DistrictBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DistrictBLL();
                return _Instance;
            }
            private set { }
        }
        private DistrictBLL()
        {
            db = new MyData();
        }
        public District GetDistrictByDistrictID(int inputDistrictID)
        {
            District result = new District();
            result = db.Districts.Where(p => p.DistrictID == inputDistrictID).FirstOrDefault();
            return result;
        }
        public List<District> GetAllDistricts()
        {
            List<District> result = db.Districts.ToList();
            return result;
        }
        public List<Ward> GetWardsInDistrict(int inputDistrictID)
        {
            List<Ward> result = new List<Ward>();
            var district = db.Districts.Where(p => p.DistrictID == inputDistrictID).FirstOrDefault();
            result = district.Wards.ToList();
            return result;
        }
        public string GetDistrictNameByID(int districtID)
        {
            return db.Districts.Where(d => d.DistrictID == districtID).FirstOrDefault().DistrictName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.BLL;
namespace PBL3.BLL
{
    public class UniversityBLL
    {
        private static MyData db;
        private static UniversityBLL _Instance;
        public static UniversityBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UniversityBLL();
                return _Instance;
            }
            private set { }
        }
        private UniversityBLL()
        {
            db = new MyData();
        }
        public University GetUniversityByUniversityID(int inputUniversityID)
        {
            University result = db.Universities.Where(p => p.UniversityID == inputUniversityID).FirstOrDefault();
            return result;
        }
        public List<University> GetAllUniversities()
        {
            List<University> result = db.Universities.ToList();
            return result;
        }
        public List<University> GetUniInWard(int inputWardID)
        {
            List<University> result = new List<University>();
            result = WardBLL.Instance.GetWardByWardID(inputWardID).Universities.ToList();
            return result;
        }
        public List<University> GetUniInDistrict(int inputDistrictID)
        {
            List<University> result = new List<University>();
            var district = DistrictBLL.Instance.GetDistrictByDistrictID(inputDistrictID);
            foreach (var i in district.Wards)
            {
                result.AddRange(GetUniInWard(i.WardID));
            }
            return result;
        }
    }
}

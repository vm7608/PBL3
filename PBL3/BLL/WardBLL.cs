using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class WardBLL
    {
        private static MyData db;
        private static WardBLL _Instance;
        public static WardBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new WardBLL();
                return _Instance;
            }
            private set { }
        }
        private WardBLL()
        {
            db = new MyData();
        }

        public Ward GetWardByWardID(int inputWardID)
        {
            Ward result = new Ward();
            result = db.Wards.FirstOrDefault(p => p.WardID == inputWardID);
            return result;
        }
        public List<Ward> GetAllWards()
        {
            return db.Wards.ToList();
        }

        public int GetWardIDByName(string wardName)
        {
            return db.Wards.FirstOrDefault(ward => ward.WardName == wardName).WardID;
        }

    }
}

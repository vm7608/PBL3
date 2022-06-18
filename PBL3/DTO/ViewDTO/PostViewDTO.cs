using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.ViewDTO
{
    public class PostViewDTO
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public int? UserID { get; set; }
        public int PostID { get; set; }
        public string Description { get; set; }
        public double Area { get; set; }
        public int Price { get; set; }
        public List<string> ImagePaths { get; set; }
    }
}

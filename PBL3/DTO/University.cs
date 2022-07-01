using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("University")]
    public class University
    {
        [Key]
        [Required]
        public int UniversityID { get; set; }
        [Required]
        public string UniversityName { get; set; }
        public int WardID { get; set; }
        [ForeignKey("WardID")]
        public virtual Ward Ward { get; set; }
    }
}

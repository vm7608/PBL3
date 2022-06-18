using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("District")]
    public class District
    {
        [Key]
        [Required]
        public int DistrictID { get; set; }

        [Required]
        public string DistrictName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Ward> Wards { get; set; }
        public District()
        {
            this.Wards = new HashSet<Ward>();
        }
    }
}

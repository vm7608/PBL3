using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [Required]
        public int AddressID { get; set; }

        [Required]
        public string DetailAddress { get; set; }

        [Required]
        public int WardID { get; set; }
        [ForeignKey("WardID")]
        public virtual Ward Ward { get; set; }
    }
}

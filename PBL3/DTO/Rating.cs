using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Rating")]
    public class Rating
    {
        [Key]
        [Required]
        public int RatingID { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [Required]
        public int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [Required]
        public int Star { get; set; } //1-> 5 sao

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}

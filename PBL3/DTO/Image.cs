using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Image")]
    public class Image
    {
        [Key]
        [Required]
        public int ImageID { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]  
        public int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}

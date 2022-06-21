using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [Required]
        public int PostID { get; set; }

        //[Required]
        public int? UserID { get; set; } //khóa ngoại có thể null -> tránh circular except
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        //[Required]
        public int? AddressID { get; set; }
        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public double Area { get; set; }

        [Required]
        public bool BeingPosted { get; set; } //default false

        [Required]
        public bool BeingRented { get; set; } //default false

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Image> Images { get; set; }

        public Post()
        {
            this.Comments = new HashSet<Comment>();
            this.Ratings = new HashSet<Rating>();
            this.Images = new HashSet<Image>();
        }
    }
}

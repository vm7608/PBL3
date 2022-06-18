using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    [Table("Role")]
    public class Role
    {
        [Key]
        [Required]
        public int RoleID { get; set; }
        [Required]
        public string RoleName { get; set; } //admin, rent, saleman

        public virtual ICollection<Account> Accounts { get; set; }

        public Role()
        {
            this.Accounts = new HashSet<Account>();
        }

    }
}

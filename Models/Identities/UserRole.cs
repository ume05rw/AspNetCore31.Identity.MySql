using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_userroles")]
    public class UserRole : IdentityUserRole<int>
    {
        [Column("user_id", TypeName = "int(11)")]
        public override int UserId { get; set; }

        [Column("role_id", TypeName = "int(11)")]
        public override int RoleId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}

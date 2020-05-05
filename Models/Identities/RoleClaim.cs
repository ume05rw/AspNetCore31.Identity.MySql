using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_roleclaims")]
    public class RoleClaim : IdentityRoleClaim<int>
    {
        [Column("id", TypeName = "int(11)")]
        public override int Id { get; set; }

        [Column("role_id", TypeName = "int(11)")]
        public override int RoleId { get; set; }

        [Column("claim_type", TypeName = "varchar(30)")]
        public override string ClaimType { get; set; }

        [Column("claim_value", TypeName = "varchar(30)")]
        public override string ClaimValue { get; set; }



        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}

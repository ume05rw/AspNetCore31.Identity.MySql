using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_roles")]
    public class Role : IdentityRole<int>
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public override int Id { get; set; }

        [Column("name", TypeName = "varchar(30)")]
        public override string Name { get; set; }

        [Column("normalized_name", TypeName = "varchar(30)")]
        public override string NormalizedName { get; set; }

        [Column("concurrency_stamp", TypeName = "varchar(256)")]
        public override string ConcurrencyStamp { get; set; }
    }
}

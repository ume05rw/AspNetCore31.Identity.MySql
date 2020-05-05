using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_users")]
    public class User : IdentityUser<int>
    {

        //[Column("lockout_end", TypeName = "double")] // マップ不能だった。
        [NotMapped]
        public override DateTimeOffset? LockoutEnd { get; set; }

        [PersonalData]
        [Column("two_factor_enabled", TypeName = "tinyint(1)")]
        public override bool TwoFactorEnabled { get; set; }
        
        
        [PersonalData]
        [Column("phone_number_confirmed", TypeName = "tinyint(1)")]
        public override bool PhoneNumberConfirmed { get; set; }
        
        [ProtectedPersonalData]
        [Column("phone_number", TypeName = "varchar(30)")]
        public override string PhoneNumber { get; set; }

        [Column("concurrency_stamp", TypeName = "varchar(256)")]
        public override string ConcurrencyStamp { get; set; }

        [Column("security_stamp", TypeName = "varchar(256)")]
        public override string SecurityStamp { get; set; }

        [Column("password_hash", TypeName = "varchar(256)")]
        public override string PasswordHash { get; set; }

        [PersonalData]
        [Column("email_confirmed", TypeName = "tinyint(1)")]
        public override bool EmailConfirmed { get; set; }

        [Column("normalized_email", TypeName = "varchar(256)")]
        public override string NormalizedEmail { get; set; }

        [ProtectedPersonalData]
        [Column("email", TypeName = "varchar(256)")]
        public override string Email { get; set; }

        [Column("normalized_user_name", TypeName = "varchar(30)")]
        public override string NormalizedUserName { get; set; }

        [ProtectedPersonalData]
        [Column("user_name", TypeName = "varchar(30)")]
        public override string UserName { get; set; }

        [PersonalData]
        [Key]
        [Column("id", TypeName = "int(11)")]
        public override int Id { get; set; }

        [Column("lockout_enabled", TypeName = "tinyint(1)")]
        public override bool LockoutEnabled { get; set; }

        [Column("access_failed_count", TypeName = "int(11)")]
        public override int AccessFailedCount { get; set; }
    }
}

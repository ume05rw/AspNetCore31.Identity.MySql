using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_userlogins")]
    public class UserLogin : IdentityUserLogin<int>
    {
        [Column("login_provider", TypeName = "varchar(30)")]
        public override string LoginProvider { get; set; }

        [Column("provider_key", TypeName = "varchar(256)")]
        public override string ProviderKey { get; set; }

        [Column("provider_display_name", TypeName = "varchar(30)")]
        public override string ProviderDisplayName { get; set; }

        [Column("user_id", TypeName = "int(11)")]
        public override int UserId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}

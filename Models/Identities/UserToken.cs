using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityMySql.Models.Identities
{
    [Table("identity_usertokens")]
    public class UserToken : IdentityUserToken<int>
    {
        [Column("user_id", TypeName = "int(11)")]
        public override int UserId { get; set; }

        [Column("login_provider", TypeName = "varchar(30)")]
        public override string LoginProvider { get; set; }

        [Column("name", TypeName = "varchar(30)")]
        public override string Name { get; set; }

        [ProtectedPersonalData]
        [Column("value", TypeName = "varchar(256)")]
        public override string Value { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}

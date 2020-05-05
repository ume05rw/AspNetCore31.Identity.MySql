using System;
using System.Collections.Generic;
using System.Text;
using IdentityMySql.Models.Identities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace IdentityMySql.Models
{
    public class Dbc : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public Dbc(DbContextOptions<Dbc> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(en => 
            {
                en.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            });

            builder.Entity<Role>(en =>
            {
                en.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            });

            builder.Entity<UserLogin>(en =>
            {
                en.HasKey(e => new
                {
                    e.LoginProvider,
                    e.ProviderKey,
                    e.UserId
                });
            });

            builder.Entity<UserRole>(en =>
            {
                en.HasKey(e => new
                {
                    e.UserId,
                    e.RoleId
                });
            });

            builder.Entity<UserToken>(en =>
            {
                en.HasKey(e => new {
                    e.UserId,
                    e.LoginProvider,
                    e.Name
                });
            });
        }

    }
}

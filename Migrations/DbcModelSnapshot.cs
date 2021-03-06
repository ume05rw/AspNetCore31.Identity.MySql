﻿// <auto-generated />
using IdentityMySql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityMySql.Migrations
{
    [DbContext(typeof(Dbc))]
    partial class DbcModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IdentityMySql.Models.Identities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("identity_roles");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("identity_roleclaims");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("access_failed_count")
                        .HasColumnType("int(11)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnName("concurrency_stamp")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("varchar(256)");

                    b.Property<byte>("EmailConfirmed")
                        .HasColumnName("email_confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("LockoutEnabled")
                        .HasColumnName("lockout_enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_user_name")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("varchar(30)");

                    b.Property<byte>("PhoneNumberConfirmed")
                        .HasColumnName("phone_number_confirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp")
                        .HasColumnType("varchar(256)");

                    b.Property<byte>("TwoFactorEnabled")
                        .HasColumnName("two_factor_enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.ToTable("identity_users");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("identity_userclaims");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name")
                        .HasColumnType("varchar(30)");

                    b.HasKey("LoginProvider", "ProviderKey", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("identity_userlogins");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.Property<int>("RoleId")
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("identity_userroles");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int(11)");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Value")
                        .HasColumnName("value")
                        .HasColumnType("varchar(256)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("identity_usertokens");
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.RoleClaim", b =>
                {
                    b.HasOne("IdentityMySql.Models.Identities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserClaim", b =>
                {
                    b.HasOne("IdentityMySql.Models.Identities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserLogin", b =>
                {
                    b.HasOne("IdentityMySql.Models.Identities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserRole", b =>
                {
                    b.HasOne("IdentityMySql.Models.Identities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IdentityMySql.Models.Identities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IdentityMySql.Models.Identities.UserToken", b =>
                {
                    b.HasOne("IdentityMySql.Models.Identities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

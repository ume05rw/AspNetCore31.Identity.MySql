using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace IdentityMySql.Migrations
{
    public partial class CreateIdentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "identity_roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: true),
                    normalized_name = table.Column<string>(type: "varchar(30)", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "varchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_roles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "identity_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    two_factor_enabled = table.Column<byte>(type: "tinyint(1)", nullable: false),
                    phone_number_confirmed = table.Column<byte>(type: "tinyint(1)", nullable: false),
                    phone_number = table.Column<string>(type: "varchar(30)", nullable: true),
                    concurrency_stamp = table.Column<string>(type: "varchar(256)", nullable: true),
                    security_stamp = table.Column<string>(type: "varchar(256)", nullable: true),
                    password_hash = table.Column<string>(type: "varchar(256)", nullable: true),
                    email_confirmed = table.Column<byte>(type: "tinyint(1)", nullable: false),
                    normalized_email = table.Column<string>(type: "varchar(256)", nullable: true),
                    email = table.Column<string>(type: "varchar(256)", nullable: true),
                    normalized_user_name = table.Column<string>(type: "varchar(30)", nullable: true),
                    user_name = table.Column<string>(type: "varchar(30)", nullable: true),
                    lockout_enabled = table.Column<byte>(type: "tinyint(1)", nullable: false),
                    access_failed_count = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "identity_roleclaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    role_id = table.Column<int>(type: "int(11)", nullable: false),
                    claim_type = table.Column<string>(type: "varchar(30)", nullable: true),
                    claim_value = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_roleclaims", x => x.id);
                    table.ForeignKey(
                        name: "FK_identity_roleclaims_identity_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "identity_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "identity_userclaims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    claim_type = table.Column<string>(type: "varchar(30)", nullable: true),
                    claim_value = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_userclaims", x => x.id);
                    table.ForeignKey(
                        name: "FK_identity_userclaims_identity_users_user_id",
                        column: x => x.user_id,
                        principalTable: "identity_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "identity_userlogins",
                columns: table => new
                {
                    login_provider = table.Column<string>(type: "varchar(30)", nullable: false),
                    provider_key = table.Column<string>(type: "varchar(256)", nullable: false),
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    provider_display_name = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_userlogins", x => new { x.login_provider, x.provider_key, x.user_id });
                    table.ForeignKey(
                        name: "FK_identity_userlogins_identity_users_user_id",
                        column: x => x.user_id,
                        principalTable: "identity_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "identity_userroles",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    role_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_userroles", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "FK_identity_userroles_identity_roles_role_id",
                        column: x => x.role_id,
                        principalTable: "identity_roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_identity_userroles_identity_users_user_id",
                        column: x => x.user_id,
                        principalTable: "identity_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "identity_usertokens",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    login_provider = table.Column<string>(type: "varchar(30)", nullable: false),
                    name = table.Column<string>(type: "varchar(30)", nullable: false),
                    value = table.Column<string>(type: "varchar(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identity_usertokens", x => new { x.user_id, x.login_provider, x.name });
                    table.ForeignKey(
                        name: "FK_identity_usertokens_identity_users_user_id",
                        column: x => x.user_id,
                        principalTable: "identity_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_identity_roleclaims_role_id",
                table: "identity_roleclaims",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_identity_userclaims_user_id",
                table: "identity_userclaims",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_identity_userlogins_user_id",
                table: "identity_userlogins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_identity_userroles_role_id",
                table: "identity_userroles",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "identity_roleclaims");

            migrationBuilder.DropTable(
                name: "identity_userclaims");

            migrationBuilder.DropTable(
                name: "identity_userlogins");

            migrationBuilder.DropTable(
                name: "identity_userroles");

            migrationBuilder.DropTable(
                name: "identity_usertokens");

            migrationBuilder.DropTable(
                name: "identity_roles");

            migrationBuilder.DropTable(
                name: "identity_users");
        }
    }
}

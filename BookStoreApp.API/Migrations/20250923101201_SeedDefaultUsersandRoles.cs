using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUsersandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ed2e5534-a0c3-4697-8c9f-be4c14d85c2f", null, "Administrator", "ADMINISTRATOR" },
                    { "fd71065d-de8f-4ec9-adf1-f4291f5d2076", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e2629c5-1603-4241-8cca-820eb2343f86", 0, "151578fb-2828-4722-acdf-ac5ae9fd362d", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEFOtffUtni5slqmveJ4eTeCc4643jQiyYkR5xFar/9oi/a0J7cX9nFLHdhsVHX+5og==", null, false, "6ebdacc9-210f-4988-a0a0-2de19f18872d", false, "user@bookstore.com" },
                    { "ec4b78e4-e2f0-47b3-9cb9-8b3f22ab547d", 0, "2a1e2835-fecd-4783-84cf-e2f8439ee6f5", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAENRwcHdq4p2HuRs8xCaSl05lcrG/HYc7GHwqxBMkHMB2xn2zPr9endClN244ZyKd9A==", null, false, "61bcc1d0-3ae3-4cd6-ac74-b633ae2732d0", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fd71065d-de8f-4ec9-adf1-f4291f5d2076", "9e2629c5-1603-4241-8cca-820eb2343f86" },
                    { "ed2e5534-a0c3-4697-8c9f-be4c14d85c2f", "ec4b78e4-e2f0-47b3-9cb9-8b3f22ab547d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd71065d-de8f-4ec9-adf1-f4291f5d2076", "9e2629c5-1603-4241-8cca-820eb2343f86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed2e5534-a0c3-4697-8c9f-be4c14d85c2f", "ec4b78e4-e2f0-47b3-9cb9-8b3f22ab547d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed2e5534-a0c3-4697-8c9f-be4c14d85c2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd71065d-de8f-4ec9-adf1-f4291f5d2076");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2629c5-1603-4241-8cca-820eb2343f86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec4b78e4-e2f0-47b3-9cb9-8b3f22ab547d");

        }
    }
}

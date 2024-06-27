using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JWT_API.Migrations
{
    /// <inheritdoc />
    public partial class SeddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "997a7334-37b4-48bf-80c3-072e21d1e53c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc740e43-a1b8-4e97-abe5-825925bd67a1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "997a7334-37b4-48bf-80c3-072e21d1e53c", "ec9b17b6-3cce-461a-960d-81663adf84b4", "User", "USER" },
                    { "dc740e43-a1b8-4e97-abe5-825925bd67a1", "cdbac72c-e534-44a8-b7b6-de4b80690c8d", "Admin", "ADMIN" }
                });
        }
    }
}

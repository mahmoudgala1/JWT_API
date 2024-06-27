using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JWT_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "99d84954-e672-4c2a-b6ae-9b59ef089ff7", "e5572c62-5184-435a-915a-1d40466d66f4", "User", "USER" },
                    { "c43434f4-41c5-4113-8fdc-62189e63d369", "25323406-d010-472d-ab5c-b037294fafbb", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99d84954-e672-4c2a-b6ae-9b59ef089ff7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c43434f4-41c5-4113-8fdc-62189e63d369");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telescope.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "District", "Name", "PhoneNumber", "PostalCode", "Province", "StreetAddress", "Ward" },
                values: new object[,]
                {
                    { 1, "Quận 11", "NGUYEN MINH HOANG", "6669990000", "12121", "Tp. Hồ Chí Minh", "351A Lạc Long Quân", "Phường 5" },
                    { 2, "Quận 11", "TRAN MINH KHOI", "1113335555", "12121", "Tp. Hồ Chí Minh", "351A Lạc Long Quân", "Phường 5" },
                    { 3, "Quận 5", "LE VAN QUY", "7779990000", "12121", "Tp. Hồ Chí Minh", "280 An Dương Vương", "Phường 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

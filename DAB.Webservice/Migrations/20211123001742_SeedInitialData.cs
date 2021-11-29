using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB.Webservice.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Balance", "Number", "Pin" },
                values: new object[,]
                {
                    { 1, 200.0, "1234567890123456", "1234" },
                    { 2, 200.0, "2345678901234567", "2345" },
                    { 3, 200.0, "3456789012345678", "3456" },
                    { 4, 200.0, "4567890123456789", "4567" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DAB.Webservice.Migrations
{
    public partial class AddTriesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthenticationTries",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Balance", "Number" },
                values: new object[] { 50.0, "1234123412341234" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Balance", "Number", "Pin" },
                values: new object[] { 100.0, "3456345634563456", "3456" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Balance", "Number", "Pin" },
                values: new object[] { 150.0, "5678567856785678", "5678" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Number", "Pin" },
                values: new object[] { "7890789078907890", "7890789078907890" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Balance", "Number", "Pin" },
                values: new object[] { 5, 250.0, "9012901290129012", "9012" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AuthenticationTries",
                table: "Account");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Balance", "Number" },
                values: new object[] { 200.0, "1234567890123456" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Balance", "Number", "Pin" },
                values: new object[] { 200.0, "2345678901234567", "2345" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Balance", "Number", "Pin" },
                values: new object[] { 200.0, "3456789012345678", "3456" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Number", "Pin" },
                values: new object[] { "4567890123456789", "4567" });
        }
    }
}

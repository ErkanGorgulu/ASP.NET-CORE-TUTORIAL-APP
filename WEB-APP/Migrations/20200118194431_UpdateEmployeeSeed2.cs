using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_APP.Migrations
{
    public partial class UpdateEmployeeSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Email" },
                values: new object[] { 1, "aprilLegget@gmail.com" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Email", "Name" },
                values: new object[] { 3, 3, "Alejandroxx@gmail.com", "Alejandro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Email" },
                values: new object[] { 2, "@aprilLegget@gmail.com" });
        }
    }
}

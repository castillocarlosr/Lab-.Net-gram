using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _4th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "/assets/pic001.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "/assets/pic002.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "/assetst/pic003.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "/assets/pic004.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "/assets/pic005.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "/assets/pic006.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "~../wwwroot/pic001.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "../wwwroot/pic002.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "../../wwwroot/pic003.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "../wwwroot/pic004.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "../wwwroot/pic005.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "../wwwroot/pic006.jpg");
        }
    }
}

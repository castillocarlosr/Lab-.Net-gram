using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _3rd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "codeFellow401.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "pic002.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "pic003.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "pic004.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "pic005.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "pic006.jpg");
        }
    }
}

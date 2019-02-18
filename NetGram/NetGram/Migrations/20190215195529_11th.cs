using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _11th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "https://via.placeholder.com/450");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "https://via.placeholder.com/250");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "https://via.placeholder.com/450");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "https://via.placeholder.com/400");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "https://via.placeholder.com/350");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "/Assets/pic001.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "../Assets/pic002.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "../../Assets/pic003.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "Assets/pic004.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "pic006.jpg");
        }
    }
}

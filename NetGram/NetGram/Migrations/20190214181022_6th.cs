using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _6th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "../assets/pic002.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "../../assetst/pic003.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "assets/pic004.jpg");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "pic005.JPG");

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "https://via.placeholder.com/150/0000FF/808080 ?Text=Place Holder");

            migrationBuilder.InsertData(
                table: "WorkGrams",
                columns: new[] { "ID", "Comments", "Title", "URL", "UserName", "Views" },
                values: new object[,]
                {
                    { 7, "7th place", "Losing 1st", "https://via.placeholder.com/150", "number 7", 1 },
                    { 8, "ROAR.", "Winning always", "pic006.JPG", "Dino", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 8);

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
                value: "C:/Users/casti/coding/codeFellows/code401/Lab-.Net-gram/NetGram/NetGram/wwwroot/Assets/pic006.jpg");
        }
    }
}

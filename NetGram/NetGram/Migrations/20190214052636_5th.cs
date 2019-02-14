using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _5th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "C:/Users/casti/coding/codeFellows/code401/Lab-.Net-gram/NetGram/NetGram/wwwroot/Assets/pic006.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                column: "URL",
                value: "/assets/pic006.jpg");
        }
    }
}

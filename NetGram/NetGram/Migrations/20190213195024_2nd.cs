using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _2nd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserName",
                value: "User Doc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                column: "UserName",
                value: "UserDos");
        }
    }
}

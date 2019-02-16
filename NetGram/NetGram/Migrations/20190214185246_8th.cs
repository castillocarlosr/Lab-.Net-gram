using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class _8th : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "ROAR", "Some Title", "https://via.placeholder.com/150", "User Holder" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Hack the world", "Friend Coding", "/Assets/pic001.JPG", "UserOne" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Making you healthy", "Doctor in office", "../Assets/pic002.jpg", "User Doc" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I do odd jobs", "Dog Coding", "../../Assets/pic003.JPG", "Mobile Lab" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I watch while you code.", "Teaching Code", "Assets/pic004.jpg", "OctoCat" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Such a reaction.", "Hood Time", "pic005.JPG", "SeattleChemist" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I get paid to eat hot dogs.", "Winning 1st", "https://via.placeholder.com/150/0000FF/808080?Text=!PlaceHolder!", "Hot Dog Champ" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "7th place", "Losing 1st", "https://via.placeholder.com/250", "number 7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Hack the world", "Friend Coding", "/Assets/pic001.JPG", "UserOne" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Making you healthy", "Doctor in office", "../Assets/pic002.jpg", "User Doc" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I do odd jobs", "Dog Coding", "../../Assets/pic003.JPG", "Mobile Lab" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I watch while you code.", "Teaching Code", "Assets/pic004.jpg", "OctoCat" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "Such a reaction.", "Hood Time", "pic005.JPG", "SeattleChemist" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "I get paid to eat hot dogs.", "Winning 1st", "https://via.placeholder.com/150/0000FF/808080 ?Text=Place Holder", "Hot Dog Champ" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "7th place", "Losing 1st", "https://via.placeholder.com/150", "number 7" });

            migrationBuilder.UpdateData(
                table: "WorkGrams",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Comments", "Title", "URL", "UserName" },
                values: new object[] { "ROAR.", "Winning always", "https://share.icloud.com/photos/07yQiqY0ilD47ec6qMDBeTYCw#International_Fountain", "Dino" });
        }
    }
}

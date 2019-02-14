using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetGram.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkGrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Views = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkGrams", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "WorkGrams",
                columns: new[] { "ID", "Comments", "Title", "URL", "UserName", "Views" },
                values: new object[,]
                {
                    { 1, "Hack the world", "Friend Coding", "codeFellow401.jpg", "UserOne", 1 },
                    { 2, "Making you healthy", "Doctor in office", "pic002.jpg", "UserDos", 1 },
                    { 3, "I do odd jobs", "Dog Coding", "pic003.jpg", "Mobile Lab", 1 },
                    { 4, "I watch while you code.", "Teaching Code", "pic004.jpg", "OctoCat", 1 },
                    { 5, "Such a reaction.", "Hood Time", "pic005.jpg", "SeattleChemist", 1 },
                    { 6, "I get paid to eat hot dogs.", "Winning 1st", "pic006.jpg", "Hot Dog Champ", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkGrams");
        }
    }
}

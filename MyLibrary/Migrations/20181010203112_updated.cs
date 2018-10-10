using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLibrary.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "Patron",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patron_LibraryId",
                table: "Patron",
                column: "LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_Library_LibraryId",
                table: "Patron",
                column: "LibraryId",
                principalTable: "Library",
                principalColumn: "LibraryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patron_Library_LibraryId",
                table: "Patron");

            migrationBuilder.DropIndex(
                name: "IX_Patron_LibraryId",
                table: "Patron");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "Patron");
        }
    }
}

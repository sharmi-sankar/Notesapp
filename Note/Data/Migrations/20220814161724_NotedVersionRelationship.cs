using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Data.Migrations
{
    public partial class NotedVersionRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VersionId",
                table: "Noteds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Noteds_VersionId",
                table: "Noteds",
                column: "VersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Noteds_Version_VersionId",
                table: "Noteds",
                column: "VersionId",
                principalTable: "Version",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Noteds_Version_VersionId",
                table: "Noteds");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropIndex(
                name: "IX_Noteds_VersionId",
                table: "Noteds");

            migrationBuilder.DropColumn(
                name: "VersionId",
                table: "Noteds");
        }
    }
}

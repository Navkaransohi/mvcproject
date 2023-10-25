using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCPROJECT.Migrations
{
    public partial class firstconfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shows = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Places = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Songs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Music = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");
        }
    }
}

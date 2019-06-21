using Microsoft.EntityFrameworkCore.Migrations;

namespace CRAC.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moviments",
                columns: table => new
                {
                    MovimentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Left = table.Column<int>(nullable: false),
                    Right = table.Column<int>(nullable: false),
                    Claw = table.Column<int>(nullable: false),
                    Base = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moviments", x => x.MovimentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moviments");
        }
    }
}

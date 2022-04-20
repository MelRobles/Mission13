using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySQLBowler.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bowlers",
                columns: table => new
                {
                    BowlerID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BowlerLastName = table.Column<string>(nullable: true),
                    BowlerFirstName = table.Column<string>(nullable: true),
                    BowlerMiddleInit = table.Column<string>(nullable: true),
                    BowlerAddress = table.Column<string>(nullable: true),
                    BowlerCity = table.Column<string>(nullable: true),
                    BowlerState = table.Column<string>(nullable: true),
                    BowlerZip = table.Column<string>(nullable: true),
                    BowlerPhoneNumber = table.Column<string>(nullable: true),
                    TeamID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bowlers", x => x.BowlerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");
        }
    }
}

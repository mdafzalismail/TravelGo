using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelGo_final.Migrations
{
    public partial class addtriptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addTrips",
                columns: table => new
                {
                    tid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tname = table.Column<string>(nullable: true),
                    tdetails = table.Column<string>(nullable: true),
                    tseason = table.Column<string>(nullable: true),
                    tprice = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addTrips", x => x.tid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addTrips");
        }
    }
}

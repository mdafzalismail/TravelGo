using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelGo_final.Migrations
{
    public partial class addUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userInfo");

            migrationBuilder.CreateTable(
                name: "addUser",
                columns: table => new
                {
                    uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addUser", x => x.uid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addUser");

            migrationBuilder.CreateTable(
                name: "userInfo",
                columns: table => new
                {
                    uid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uphone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInfo", x => x.uid);
                });
        }
    }
}

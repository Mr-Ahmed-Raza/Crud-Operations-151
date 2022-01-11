using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_OPERATIONS__151.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orderModels",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Descirption = table.Column<string>(nullable: true),
                    Quatity = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderModels", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderModels");
        }
    }
}

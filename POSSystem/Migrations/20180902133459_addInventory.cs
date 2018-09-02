using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSystem.Migrations
{
    public partial class addInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(nullable: true),
                    ItemPrice = table.Column<string>(nullable: true),
                    ItemStockNumber = table.Column<string>(nullable: true),
                    ItemEANNumber = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.ItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventorys");
        }
    }
}

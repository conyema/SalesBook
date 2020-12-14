using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurant.Data.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Requisitions",
                newName: "SKU");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Requisitions",
                newName: "ReqId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SKU",
                table: "Requisitions",
                newName: "StockId");

            migrationBuilder.RenameColumn(
                name: "ReqId",
                table: "Requisitions",
                newName: "Id");
        }
    }
}

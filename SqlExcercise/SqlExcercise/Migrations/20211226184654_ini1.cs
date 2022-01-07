using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlExcercise.Migrations
{
    public partial class ini1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order=1",
                table: "stocks",
                newName: "Product_Id");

            migrationBuilder.RenameColumn(
                name: "Order=0",
                table: "stocks",
                newName: "Store_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Id",
                table: "stocks",
                newName: "Order=1");

            migrationBuilder.RenameColumn(
                name: "Store_Id",
                table: "stocks",
                newName: "Order=0");
        }
    }
}

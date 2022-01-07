using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlExcercise.Migrations
{
    public partial class ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Order0 = table.Column<int>(name: "Order=0", nullable: false),
                    Order1 = table.Column<int>(name: "Order=1", nullable: false),
                    Quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => new { x.Order0, x.Order1 });
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Store_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.Store_Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(nullable: false),
                    Order_Status = table.Column<string>(nullable: false),
                    Order_Date = table.Column<DateTime>(nullable: false),
                    Requried_Date = table.Column<DateTime>(nullable: false),
                    Shipped_Date = table.Column<DateTime>(nullable: false),
                    Store_Id = table.Column<int>(nullable: false),
                    Staff_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Order_Id);
                    table.ForeignKey(
                        name: "FK_orders_customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_stores_Store_Id",
                        column: x => x.Store_Id,
                        principalTable: "stores",
                        principalColumn: "Store_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    Staff_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frist_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    Active = table.Column<string>(nullable: true),
                    Store_Id = table.Column<int>(nullable: false),
                    Manager_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.Staff_Id);
                    table.ForeignKey(
                        name: "FK_staffs_stores_Store_Id",
                        column: x => x.Store_Id,
                        principalTable: "stores",
                        principalColumn: "Store_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_Customer_Id",
                table: "orders",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Store_Id",
                table: "orders",
                column: "Store_Id");

            migrationBuilder.CreateIndex(
                name: "IX_staffs_Store_Id",
                table: "staffs",
                column: "Store_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}

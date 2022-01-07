using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sqlmv_Project.Migrations
{
    public partial class intial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Brand_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Brand_Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Frist_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Customer_Id);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item_Id = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    List_Price = table.Column<double>(nullable: false),
                    Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_items", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(nullable: false),
                    Order_Status = table.Column<string>(nullable: true),
                    Order_Date = table.Column<DateTime>(nullable: false),
                    Requried_Date = table.Column<DateTime>(nullable: false),
                    Shipped_Date = table.Column<DateTime>(nullable: false),
                    Store_Id = table.Column<int>(nullable: false),
                    Staff_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(nullable: true),
                    Brand_Id = table.Column<int>(nullable: false),
                    Category_Id = table.Column<int>(nullable: false),
                    Model_Year = table.Column<string>(nullable: true),
                    List_Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Product_Id);
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
                    Phone = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Store_Id = table.Column<int>(nullable: false),
                    Manager_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.Staff_Id);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Store_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Id = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.Store_Id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Store_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.Store_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}

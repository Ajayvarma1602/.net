using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlExcercise.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Brand_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(nullable: false)
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
                    Category_Name = table.Column<string>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_products_brands_Brand_Id",
                        column: x => x.Brand_Id,
                        principalTable: "brands",
                        principalColumn: "Brand_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_categories_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false),
                    Item_Id = table.Column<int>(nullable: false),
                    Product_Id = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    List_Price = table.Column<double>(nullable: false),
                    Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_items", x => new { x.Order_Id, x.Item_Id });
                    table.ForeignKey(
                        name: "FK_order_items_products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_items_Product_Id",
                table: "order_items",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Brand_Id",
                table: "products",
                column: "Brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_products_Category_Id",
                table: "products",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}

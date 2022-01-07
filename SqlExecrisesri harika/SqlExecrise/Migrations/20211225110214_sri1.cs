using Microsoft.EntityFrameworkCore.Migrations;

namespace SqlExecrise.Migrations
{
    public partial class sri1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
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
                name: "stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Store_Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}

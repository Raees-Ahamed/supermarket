using Microsoft.EntityFrameworkCore.Migrations;

namespace MySuperMarket.DAL.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CurrentPrice", "Description", "Name", "StockAvailable" },
                values: new object[] { 1, 160, "Daily Milk", "Chocolate", 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CurrentPrice", "Description", "Name", "StockAvailable" },
                values: new object[] { 2, 5, "My Lady", "Toffee", 70 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CurrentPrice", "Description", "Name", "StockAvailable" },
                values: new object[] { 3, 50, "Soap", "Baby Soap", 90 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");
        }
    }
}

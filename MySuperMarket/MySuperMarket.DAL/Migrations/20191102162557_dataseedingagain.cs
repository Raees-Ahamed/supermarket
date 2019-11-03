using Microsoft.EntityFrameworkCore.Migrations;

namespace MySuperMarket.DAL.Migrations
{
    public partial class dataseedingagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6cccbcc8-76d8-45d4-a9e3-5a04fb144b3a", 0, "Colombo", "8d400cd8-fc85-4e3d-acca-1ac60e987990", "Umair@gmail.com", false, "Umair", "Anhar", false, null, null, null, null, "0773060490", false, "9de0ea32-33d5-4411-bb9f-b81f0617c1e5", 0, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4a16b15-40b4-4407-95cc-969e2cb7bc99", 0, "Panadura", "8f3ef8fe-1373-4b0c-a07c-f2c41218de36", "Anhar@gmail.com", false, "Anhar", "Paavada", false, null, null, null, null, "0773060400", false, "7be89b81-0165-48c4-9657-32c2a0f985eb", 0, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "24627594-eb2d-4176-afd8-55ce8f076a9d", 0, "Negambo", "4db1a8b6-1f86-4881-b304-af9d1a101f30", "Ajmal@gmail.com", false, "Ajmal", "Ponsamy", false, null, null, null, null, "0773060430", false, "70092ed9-277d-464b-8b2f-298f616132d9", 0, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24627594-eb2d-4176-afd8-55ce8f076a9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6cccbcc8-76d8-45d4-a9e3-5a04fb144b3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4a16b15-40b4-4407-95cc-969e2cb7bc99");
        }
    }
}

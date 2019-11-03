using Microsoft.EntityFrameworkCore.Migrations;

namespace MySuperMarket.DAL.Migrations
{
    public partial class dataseedingpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "780d06d7-06db-4fe7-8ff5-6a8c44ea1e6d", 0, "Colombo", "320259e0-f499-4c8e-9b0b-c3b1c599cef8", "Umair@gmail.com", false, "Umair", "Anhar", false, null, null, null, "123", "0773060490", false, "bd6df338-19fc-48e4-a343-5f271ae45fc6", 0, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b23c146d-be2e-4474-9def-c45386e77968", 0, "Panadura", "bbdef2c8-112e-4c0f-a7b1-09c3429080e4", "Anhar@gmail.com", false, "Anhar", "Paavada", false, null, null, null, "1243", "0773060400", false, "1beb182d-7228-492b-8b7b-ca01d4beb05d", 0, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TelephoneNumber", "TwoFactorEnabled", "UserName" },
                values: new object[] { "493bf35d-ce31-429a-b505-29887abbad67", 0, "Negambo", "3a36a098-d07d-452a-811b-7c7568110cae", "Ajmal@gmail.com", false, "Ajmal", "Ponsamy", false, null, null, null, "1243s", "0773060430", false, "e15b1ace-291d-49b1-9a0a-97387ebf204b", 0, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "493bf35d-ce31-429a-b505-29887abbad67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "780d06d7-06db-4fe7-8ff5-6a8c44ea1e6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b23c146d-be2e-4474-9def-c45386e77968");

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
    }
}

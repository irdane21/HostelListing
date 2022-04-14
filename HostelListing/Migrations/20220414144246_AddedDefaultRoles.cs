using Microsoft.EntityFrameworkCore.Migrations;

namespace HostelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa30863b-5cab-48ec-a69d-a3599fa45818", "e61f39b2-a3cd-4ef7-a702-a3145dfa7feb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb8965eb-90db-4de6-adbf-2d83fab51eab", "7af1ff03-5cc6-4b08-8813-274160ff6620", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb8965eb-90db-4de6-adbf-2d83fab51eab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa30863b-5cab-48ec-a69d-a3599fa45818");
        }
    }
}

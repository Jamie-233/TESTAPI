using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TEST.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Feature", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("a6612a48-7b7d-4fd2-a4f3-266ab17dc649"), new DateTime(2022, 8, 13, 14, 38, 50, 657, DateTimeKind.Utc).AddTicks(1290), null, "description", null, null, null, null, 0m, "test title", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("a6612a48-7b7d-4fd2-a4f3-266ab17dc649"));
        }
    }
}

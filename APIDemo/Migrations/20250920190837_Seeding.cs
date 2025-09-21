using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIDemo.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Brand", "Model", "ToyName" },
                values: new object[,]
                {
                    { 1, "LEGO", "75257", "Millennium Falcon" },
                    { 2, "Mattel", "FHY73", "Barbie Dreamhouse" },
                    { 3, "Mattel", "GGH70", "Hot Wheels Track Builder" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

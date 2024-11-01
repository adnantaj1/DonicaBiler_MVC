using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DonicaBiler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCarTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FuelConsumption",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "EngineSize",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Acceleration",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Acceleration", "EngineSize", "FirstRegistration", "FuelConsumption", "FuelType", "GreenOwnershipTax", "Kilometers", "MaxTowingWeight", "Price", "TopSpeed", "Type", "Year" },
                values: new object[,]
                {
                    { 1, 9.2m, 1.8m, new DateTime(2015, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.5m, "Petrol", 200m, 50000, 1200, 15000m, 180, "Sedan", 2015 },
                    { 2, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, 30000, 1500, 25000m, 210, "SUV", 2017 }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "CarImageId", "CarId", "ImageUrl" },
                values: new object[,]
                {
                    { 1, 1, "https://example.com/image1.jpg" },
                    { 2, 1, "https://example.com/image2.jpg" },
                    { 3, 2, "https://example.com/image3.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "CarImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "CarImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarImages",
                keyColumn: "CarImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 2);

            migrationBuilder.AlterColumn<double>(
                name: "FuelConsumption",
                table: "Cars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "EngineSize",
                table: "Cars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Acceleration",
                table: "Cars",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}

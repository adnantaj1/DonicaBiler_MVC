using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DonicaBiler.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreCarItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Acceleration", "EngineSize", "FirstRegistration", "FuelConsumption", "FuelType", "GreenOwnershipTax", "ImageUrl", "Kilometers", "MaxTowingWeight", "ModelName", "Price", "TopSpeed", "Type", "Year" },
                values: new object[,]
                {
                    { 3, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 },
                    { 4, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 },
                    { 5, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 },
                    { 6, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 },
                    { 7, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 },
                    { 8, 7.5m, 2.0m, new DateTime(2017, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.5m, "Diesel", 250m, "https://images.unsplash.com/photo-1542362567-b07e54358753?ixlib=rb-1.2.1&auto=format&fit=crop&w=500&q=60", 30000, 1500, "Toyota Yaris Hybrid H3 e-CVT", 25000m, 210, "SUV", 2017 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 8);
        }
    }
}

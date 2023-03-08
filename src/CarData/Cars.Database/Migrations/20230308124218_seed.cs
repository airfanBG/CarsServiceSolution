using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cars.Database.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarSchedulers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ModifiedAt", "VisitAt" },
                values: new object[,]
                {
                    { "0a88549c-d22e-4907-83c9-93bc089909f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "1dee7629-74c2-47dc-9524-78fc77307fb1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "3b6c3967-7be0-4263-830a-e31d17118092", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "8c0b6603-6ebd-4620-8fdf-aa4b0dd79a27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarBrand", "CarModel", "CarSchedulerId", "CarShedulerId", "CreatedAt", "DeletedAt", "ModifiedAt" },
                values: new object[,]
                {
                    { "1912b66c-b6b8-4894-9d59-f82df68256b7", "Ford", "Focus", null, "3b6c3967-7be0-4263-830a-e31d17118092", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "915b1cd4-0561-4581-9c3b-1bf9c56f6368", "BMW", "314", null, "0a88549c-d22e-4907-83c9-93bc089909f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "9afbb6d8-09fe-4f01-9003-81e8d2d8b28e", "Peugeot", "205", null, "1dee7629-74c2-47dc-9524-78fc77307fb1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "a02c60d9-016c-4f1d-a1ca-ce1f55bd7478", "Audi", "A6", null, "0a88549c-d22e-4907-83c9-93bc089909f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "e9f2fefd-ae4d-431d-9c5f-aff50b6c110a", "Mercedes", "s220", null, "8c0b6603-6ebd-4620-8fdf-aa4b0dd79a27", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CarProblems",
                columns: new[] { "Id", "CarId", "CarPart", "CreatedAt", "DeletedAt", "Description", "ModifiedAt", "TotalAmount" },
                values: new object[,]
                {
                    { "03ab6a5a-49db-4890-9335-ddd8700a8c19", "915b1cd4-0561-4581-9c3b-1bf9c56f6368", "breaks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaks cylinders", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m },
                    { "1134f1aa-4c4a-49f8-abfa-f520a494a63c", "1912b66c-b6b8-4894-9d59-f82df68256b7", "wheels", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shocking absorbers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 600m },
                    { "3542efaf-718c-4b3a-b6d5-116d25e0c06f", "915b1cd4-0561-4581-9c3b-1bf9c56f6368", "Clutch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Change the clutch", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m },
                    { "8ff516e4-97a4-42a3-922e-3b7973c38cf9", "a02c60d9-016c-4f1d-a1ca-ce1f55bd7478", "Engine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIlters and oils", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 350m },
                    { "c5cfe27f-52d5-4147-947a-8f794dc31aee", "e9f2fefd-ae4d-431d-9c5f-aff50b6c110a", "engine", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Timing belt change", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1300m },
                    { "c9ea652b-f4cd-4d23-b1c6-61e3084301ad", "9afbb6d8-09fe-4f01-9003-81e8d2d8b28e", "transmission", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gear bearing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "03ab6a5a-49db-4890-9335-ddd8700a8c19");

            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "1134f1aa-4c4a-49f8-abfa-f520a494a63c");

            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "3542efaf-718c-4b3a-b6d5-116d25e0c06f");

            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "8ff516e4-97a4-42a3-922e-3b7973c38cf9");

            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "c5cfe27f-52d5-4147-947a-8f794dc31aee");

            migrationBuilder.DeleteData(
                table: "CarProblems",
                keyColumn: "Id",
                keyValue: "c9ea652b-f4cd-4d23-b1c6-61e3084301ad");

            migrationBuilder.DeleteData(
                table: "CarSchedulers",
                keyColumn: "Id",
                keyValue: "0a88549c-d22e-4907-83c9-93bc089909f9");

            migrationBuilder.DeleteData(
                table: "CarSchedulers",
                keyColumn: "Id",
                keyValue: "1dee7629-74c2-47dc-9524-78fc77307fb1");

            migrationBuilder.DeleteData(
                table: "CarSchedulers",
                keyColumn: "Id",
                keyValue: "3b6c3967-7be0-4263-830a-e31d17118092");

            migrationBuilder.DeleteData(
                table: "CarSchedulers",
                keyColumn: "Id",
                keyValue: "8c0b6603-6ebd-4620-8fdf-aa4b0dd79a27");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "1912b66c-b6b8-4894-9d59-f82df68256b7");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "915b1cd4-0561-4581-9c3b-1bf9c56f6368");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "9afbb6d8-09fe-4f01-9003-81e8d2d8b28e");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "a02c60d9-016c-4f1d-a1ca-ce1f55bd7478");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: "e9f2fefd-ae4d-431d-9c5f-aff50b6c110a");
        }
    }
}

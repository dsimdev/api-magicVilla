using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class DataDefaultEnTablaVillas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalles", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalles de la villa 1", new DateTime(2023, 11, 7, 13, 33, 10, 168, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 11, 7, 13, 33, 10, 168, DateTimeKind.Local).AddTicks(9559), "", 150.5, "Villa 1", 5, 1500.5 },
                    { 2, "", "Detalles de la villa 2", new DateTime(2023, 11, 7, 13, 33, 10, 168, DateTimeKind.Local).AddTicks(9574), new DateTime(2023, 11, 7, 13, 33, 10, 168, DateTimeKind.Local).AddTicks(9573), "", 1540.5, "Villa 2", 15, 10500.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InstallDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "WorkCalendars",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 19, 23, 30, 28, 237, DateTimeKind.Local).AddTicks(1560));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "WorkCalendars",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3233));
        }
    }
}

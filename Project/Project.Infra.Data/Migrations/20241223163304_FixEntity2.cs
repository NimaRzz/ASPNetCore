using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEntity2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassportCode",
                table: "Citizens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 20, 3, 3, 42, DateTimeKind.Local).AddTicks(5708));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PassportCode",
                table: "Citizens",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 23, 7, 29, 26, 73, DateTimeKind.Local).AddTicks(8050));
        }
    }
}

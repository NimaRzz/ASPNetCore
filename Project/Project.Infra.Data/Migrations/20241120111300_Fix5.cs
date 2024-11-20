using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewId",
                table: "Offices");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Offices",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 43, 0, 93, DateTimeKind.Local).AddTicks(5405));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Offices");

            migrationBuilder.AddColumn<string>(
                name: "NewId",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 31, 41, 490, DateTimeKind.Local).AddTicks(3587));
        }
    }
}

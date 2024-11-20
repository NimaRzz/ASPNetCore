using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NewId",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NewId",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 14, 29, 16, 102, DateTimeKind.Local).AddTicks(6706));
        }
    }
}

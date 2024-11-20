using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix_Citizen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UniqueCode",
                table: "Citizens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PersonalizedCode",
                table: "Citizens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "PassportCode",
                table: "Citizens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "HouseholdCode",
                table: "Citizens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 8, 1, 30, 903, DateTimeKind.Local).AddTicks(1191));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UniqueCode",
                table: "Citizens",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PersonalizedCode",
                table: "Citizens",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "PassportCode",
                table: "Citizens",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "HouseholdCode",
                table: "Citizens",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 19, 15, 2, 32, 95, DateTimeKind.Local).AddTicks(1655));
        }
    }
}

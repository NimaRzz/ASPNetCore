using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Offices_OfficeId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Plans_PlanId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_WorkCalendars_WorkCalendarId",
                table: "Shifts");

            migrationBuilder.AddColumn<string>(
                name: "NewId",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OfficePlans_Offices_OfficeId",
                table: "OfficePlans",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OfficePlans_Plans_PlanId",
                table: "OfficePlans",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_WorkCalendars_WorkCalendarId",
                table: "Shifts",
                column: "WorkCalendarId",
                principalTable: "WorkCalendars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Offices_OfficeId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Plans_PlanId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_WorkCalendars_WorkCalendarId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "NewId",
                table: "Offices");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 36, 38, 886, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.AddForeignKey(
                name: "FK_OfficePlans_Offices_OfficeId",
                table: "OfficePlans",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfficePlans_Plans_PlanId",
                table: "OfficePlans",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shifts_WorkCalendars_WorkCalendarId",
                table: "Shifts",
                column: "WorkCalendarId",
                principalTable: "WorkCalendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

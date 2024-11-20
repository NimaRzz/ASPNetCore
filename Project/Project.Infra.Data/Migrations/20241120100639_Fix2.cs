using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OfficeId",
                table: "WorkCalendars",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "WorkCalendarId",
                table: "Shifts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "OfficeId",
                table: "OfficePlans",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PlanId",
                table: "OfficePlans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "OfficeId",
                table: "Citizens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "CitizenId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PlanId",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkCalendars_OfficeId",
                table: "WorkCalendars",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_WorkCalendarId",
                table: "Shifts",
                column: "WorkCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficePlans_OfficeId",
                table: "OfficePlans",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficePlans_PlanId",
                table: "OfficePlans",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_OfficeId",
                table: "Citizens",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CitizenId",
                table: "Appointments",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PlanId",
                table: "Appointments",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Citizens_CitizenId",
                table: "Appointments",
                column: "CitizenId",
                principalTable: "Citizens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Plans_PlanId",
                table: "Appointments",
                column: "PlanId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citizens_Offices_OfficeId",
                table: "Citizens",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCalendars_Offices_OfficeId",
                table: "WorkCalendars",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Citizens_CitizenId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Plans_PlanId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Citizens_Offices_OfficeId",
                table: "Citizens");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Offices_OfficeId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_OfficePlans_Plans_PlanId",
                table: "OfficePlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Shifts_WorkCalendars_WorkCalendarId",
                table: "Shifts");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCalendars_Offices_OfficeId",
                table: "WorkCalendars");

            migrationBuilder.DropIndex(
                name: "IX_WorkCalendars_OfficeId",
                table: "WorkCalendars");

            migrationBuilder.DropIndex(
                name: "IX_Shifts_WorkCalendarId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_OfficePlans_OfficeId",
                table: "OfficePlans");

            migrationBuilder.DropIndex(
                name: "IX_OfficePlans_PlanId",
                table: "OfficePlans");

            migrationBuilder.DropIndex(
                name: "IX_Citizens_OfficeId",
                table: "Citizens");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_CitizenId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PlanId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "WorkCalendars");

            migrationBuilder.DropColumn(
                name: "WorkCalendarId",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "OfficePlans");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "OfficePlans");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Citizens");

            migrationBuilder.DropColumn(
                name: "CitizenId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5416));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    StartPlan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndPlan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    ProvinceId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offices_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInRole",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseholdCode = table.Column<long>(type: "bigint", nullable: false),
                    UniqueCode = table.Column<long>(type: "bigint", nullable: false),
                    PassportCode = table.Column<long>(type: "bigint", nullable: false),
                    PersonalizedCode = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citizens_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficePlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficePlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficePlans_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OfficePlans_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkCalendars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Workday = table.Column<int>(type: "int", nullable: false),
                    WorkStart = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkEnd = table.Column<TimeSpan>(type: "time", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCalendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkCalendars_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CitizenId = table.Column<long>(type: "bigint", nullable: false),
                    PlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Citizens_CitizenId",
                        column: x => x.CitizenId,
                        principalTable: "Citizens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2491), false, "AzarbaijanSharghi", null, null },
                    { 2L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2541), false, "AzarbaijanGharbi", null, null },
                    { 3L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2564), false, "Ardabil", null, null },
                    { 4L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2585), false, "Isfahan", null, null },
                    { 5L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2607), false, "Alborz", null, null },
                    { 6L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2633), false, "Ilam", null, null },
                    { 7L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2655), false, "Bushehr", null, null },
                    { 8L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2676), false, "Tehran", null, null },
                    { 9L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2697), false, "ChaharmahaloBakhtiari", null, null },
                    { 10L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2720), false, "KhorasanJonubi", null, null },
                    { 11L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2743), false, "KhorasanRazavi", null, null },
                    { 12L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2764), false, "KhorasanShomali", null, null },
                    { 13L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2786), false, "Khuzestan", null, null },
                    { 14L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2808), false, "Zanjan", null, null },
                    { 15L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2831), false, "Semnan", null, null },
                    { 16L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2904), false, "SistanoBaluchestan", null, null },
                    { 17L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2928), false, "Fars", null, null },
                    { 18L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2953), false, "Qazvin", null, null },
                    { 19L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(2977), false, "Qom", null, null },
                    { 20L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3000), false, "Kurdistan", null, null },
                    { 21L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3021), false, "Kerman", null, null },
                    { 22L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3044), false, "Kermanshah", null, null },
                    { 23L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3066), false, "KohgiluyehoBoyerahmad", null, null },
                    { 24L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3088), false, "Golestan", null, null },
                    { 25L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3109), false, "Gilan", null, null },
                    { 26L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3130), false, "Lorestan", null, null },
                    { 27L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3150), false, "Mazandaran", null, null },
                    { 28L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3171), false, "Markazi", null, null },
                    { 29L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3192), false, "Hormozgan", null, null },
                    { 30L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3213), false, "Hamadan", null, null },
                    { 31L, new DateTime(2024, 11, 25, 15, 22, 12, 275, DateTimeKind.Local).AddTicks(3233), false, "Yazd", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1L, null, false, "Citizen", null, null },
                    { 2L, null, false, "Admin", null, null },
                    { 3L, null, false, "Operator", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CitizenId",
                table: "Appointments",
                column: "CitizenId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PlanId",
                table: "Appointments",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Citizens_OfficeId",
                table: "Citizens",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficePlans_OfficeId",
                table: "OfficePlans",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficePlans_PlanId",
                table: "OfficePlans",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Offices_ProvinceId",
                table: "Offices",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInRole_RoleId",
                table: "UserInRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInRole_UserId",
                table: "UserInRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCalendars_OfficeId",
                table: "WorkCalendars",
                column: "OfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "OfficePlans");

            migrationBuilder.DropTable(
                name: "UserInRole");

            migrationBuilder.DropTable(
                name: "WorkCalendars");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}

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
                    StartPlan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndPlan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    ProvinceId = table.Column<long>(type: "bigint", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseholdCode = table.Column<long>(type: "bigint", nullable: false),
                    UniqueCode = table.Column<long>(type: "bigint", nullable: false),
                    PassportCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalizedCode = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfficePlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { 1L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5523), false, "AzarbaijanSharghi", null, null },
                    { 2L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5576), false, "AzarbaijanGharbi", null, null },
                    { 3L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5595), false, "Ardabil", null, null },
                    { 4L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5611), false, "Isfahan", null, null },
                    { 5L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5626), false, "Alborz", null, null },
                    { 6L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5644), false, "Ilam", null, null },
                    { 7L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5661), false, "Bushehr", null, null },
                    { 8L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5676), false, "Tehran", null, null },
                    { 9L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5692), false, "ChaharmahaloBakhtiari", null, null },
                    { 10L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5708), false, "KhorasanJonubi", null, null },
                    { 11L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5724), false, "KhorasanRazavi", null, null },
                    { 12L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5740), false, "KhorasanShomali", null, null },
                    { 13L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5756), false, "Khuzestan", null, null },
                    { 14L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5772), false, "Zanjan", null, null },
                    { 15L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5787), false, "Semnan", null, null },
                    { 16L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5802), false, "SistanoBaluchestan", null, null },
                    { 17L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5819), false, "Fars", null, null },
                    { 18L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5835), false, "Qazvin", null, null },
                    { 19L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5850), false, "Qom", null, null },
                    { 20L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5865), false, "Kurdistan", null, null },
                    { 21L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5881), false, "Kerman", null, null },
                    { 22L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5896), false, "Kermanshah", null, null },
                    { 23L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5911), false, "KohgiluyehoBoyerahmad", null, null },
                    { 24L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5949), false, "Golestan", null, null },
                    { 25L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5966), false, "Gilan", null, null },
                    { 26L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5982), false, "Lorestan", null, null },
                    { 27L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(5997), false, "Mazandaran", null, null },
                    { 28L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(6014), false, "Markazi", null, null },
                    { 29L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(6028), false, "Hormozgan", null, null },
                    { 30L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(6044), false, "Hamadan", null, null },
                    { 31L, new DateTime(2024, 12, 24, 22, 52, 19, 682, DateTimeKind.Local).AddTicks(6060), false, "Yazd", null, null }
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
                name: "Users");

            migrationBuilder.DropTable(
                name: "WorkCalendars");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}

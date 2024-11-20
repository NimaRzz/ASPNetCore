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
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
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
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficePlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    WorkStart = table.Column<TimeSpan>(type: "time", nullable: false),
                    WorkEnd = table.Column<TimeSpan>(type: "time", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficePlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
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
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
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
                name: "WorkCalendars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Holidays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCalendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5078), false, "AzarbaijanSharghi", null, null },
                    { 2L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5104), false, "AzarbaijanGharbi", null, null },
                    { 3L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5113), false, "Ardabil", null, null },
                    { 4L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5123), false, "Isfahan", null, null },
                    { 5L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5134), false, "Alborz", null, null },
                    { 6L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5145), false, "Ilam", null, null },
                    { 7L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5154), false, "Bushehr", null, null },
                    { 8L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5164), false, "Tehran", null, null },
                    { 9L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5173), false, "ChaharmahaloBakhtiari", null, null },
                    { 10L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5183), false, "KhorasanJonubi", null, null },
                    { 11L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5192), false, "KhorasanRazavi", null, null },
                    { 12L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5201), false, "KhorasanShomali", null, null },
                    { 13L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5211), false, "Khuzestan", null, null },
                    { 14L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5220), false, "Zanjan", null, null },
                    { 15L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5229), false, "Semnan", null, null },
                    { 16L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5237), false, "SistanoBaluchestan", null, null },
                    { 17L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5248), false, "Fars", null, null },
                    { 18L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5258), false, "Qazvin", null, null },
                    { 19L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5266), false, "Qom", null, null },
                    { 20L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5275), false, "Kurdistan", null, null },
                    { 21L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5322), false, "Kerman", null, null },
                    { 22L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5332), false, "Kermanshah", null, null },
                    { 23L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5342), false, "KohgiluyehoBoyerahmad", null, null },
                    { 24L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5351), false, "Golestan", null, null },
                    { 25L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5361), false, "Gilan", null, null },
                    { 26L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5370), false, "Lorestan", null, null },
                    { 27L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5379), false, "Mazandaran", null, null },
                    { 28L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5389), false, "Markazi", null, null },
                    { 29L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5398), false, "Hormozgan", null, null },
                    { 30L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5407), false, "Hamadan", null, null },
                    { 31L, new DateTime(2024, 11, 20, 13, 33, 0, 708, DateTimeKind.Local).AddTicks(5416), false, "Yazd", null, null }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Citizens");

            migrationBuilder.DropTable(
                name: "OfficePlans");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "UserInRole");

            migrationBuilder.DropTable(
                name: "WorkCalendars");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

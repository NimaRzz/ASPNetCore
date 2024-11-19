using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Province : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "Offices");

            migrationBuilder.AddColumn<long>(
                name: "ProvinceId",
                table: "Offices",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "InsertTime", "IsRemoved", "Name", "RemoveTime", "UpdateTime" },
                values: new object[,]
                {
                    { 1L, null, false, "AzarbaijanSharghi", null, null },
                    { 2L, null, false, "AzarbaijanGharbi", null, null },
                    { 3L, null, false, "Ardabil", null, null },
                    { 4L, null, false, "Isfahan", null, null },
                    { 5L, null, false, "Alborz", null, null },
                    { 6L, null, false, "Ilam", null, null },
                    { 7L, null, false, "Bushehr", null, null },
                    { 8L, null, false, "Tehran", null, null },
                    { 9L, null, false, "ChaharmahaloBakhtiari", null, null },
                    { 10L, null, false, "KhorasanJonubi", null, null },
                    { 11L, null, false, "KhorasanRazavi", null, null },
                    { 12L, null, false, "KhorasanShomali", null, null },
                    { 13L, null, false, "Khuzestan", null, null },
                    { 14L, null, false, "Zanjan", null, null },
                    { 15L, null, false, "Semnan", null, null },
                    { 16L, null, false, "SistanoBaluchestan", null, null },
                    { 17L, null, false, "Fars", null, null },
                    { 18L, null, false, "Qazvin", null, null },
                    { 19L, null, false, "Qom", null, null },
                    { 20L, null, false, "Kurdistan", null, null },
                    { 21L, null, false, "Kerman", null, null },
                    { 22L, null, false, "Kermanshah", null, null },
                    { 23L, null, false, "KohgiluyehoBoyerahmad", null, null },
                    { 24L, null, false, "Golestan", null, null },
                    { 25L, null, false, "Gilan", null, null },
                    { 26L, null, false, "Lorestan", null, null },
                    { 27L, null, false, "Mazandaran", null, null },
                    { 28L, null, false, "Markazi", null, null },
                    { 29L, null, false, "Hormozgan", null, null },
                    { 30L, null, false, "Hamadan", null, null },
                    { 31L, null, false, "Yazd", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offices_ProvinceId",
                table: "Offices",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offices_Provinces_ProvinceId",
                table: "Offices",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offices_Provinces_ProvinceId",
                table: "Offices");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropIndex(
                name: "IX_Offices_ProvinceId",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Offices");

            migrationBuilder.AddColumn<int>(
                name: "Province",
                table: "Offices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class userAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 214, DateTimeKind.Local).AddTicks(1345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 443, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(7113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 214, DateTimeKind.Local).AddTicks(79),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 443, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(8893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(5705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 206, DateTimeKind.Local).AddTicks(3337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 435, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.CreateTable(
                name: "UserAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 214, DateTimeKind.Local).AddTicks(2763)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddresses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAddresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 443, DateTimeKind.Local).AddTicks(1656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 214, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(7411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 443, DateTimeKind.Local).AddTicks(417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 214, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(9233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(5978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 435, DateTimeKind.Local).AddTicks(2968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 206, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 10, 13, 9, 17, 442, DateTimeKind.Local).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 11, 14, 15, 47, 213, DateTimeKind.Local).AddTicks(3835));
        }
    }
}

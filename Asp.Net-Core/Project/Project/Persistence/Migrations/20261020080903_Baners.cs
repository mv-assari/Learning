using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Baners : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(7413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(3085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(5809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(8721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(2215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(7423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 654, DateTimeKind.Local).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 331, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 657, DateTimeKind.Local).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(6052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(8851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(3307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 659, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(4803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(28),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(3000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 658, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 331, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 654, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(1449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 11, 39, 2, 657, DateTimeKind.Local).AddTicks(8870));
        }
    }
}

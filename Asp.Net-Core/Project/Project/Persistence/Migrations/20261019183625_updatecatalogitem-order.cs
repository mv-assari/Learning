using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updatecatalogitemorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(6052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.AddColumn<int>(
                name: "CatalogItemId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(8851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(3307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(1441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(4803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.AddColumn<int>(
                name: "VisitCount",
                table: "catalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(28),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(8754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(3000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 331, DateTimeKind.Local).AddTicks(6703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 618, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(1449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CatalogItemId",
                table: "Orders",
                column: "CatalogItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_catalogItems_CatalogItemId",
                table: "OrderItems",
                column: "CatalogItemId",
                principalTable: "catalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_catalogItems_CatalogItemId",
                table: "Orders",
                column: "CatalogItemId",
                principalTable: "catalogItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_catalogItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_catalogItems_CatalogItemId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CatalogItemId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_CatalogItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CatalogItemId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "VisitCount",
                table: "catalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(8431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(7108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 337, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(5903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(3294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(7799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 336, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(5506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(1597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 618, DateTimeKind.Local).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 331, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 19, 22, 6, 25, 335, DateTimeKind.Local).AddTicks(1449));
        }
    }
}

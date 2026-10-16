using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DiscountcatalogItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_catalogItems_Discounts_DiscountId",
                table: "catalogItems");

            migrationBuilder.DropIndex(
                name: "IX_catalogItems_DiscountId",
                table: "catalogItems");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "catalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(6872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(5054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(2002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(3675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(5090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(8061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(6979),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(3756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 540, DateTimeKind.Local).AddTicks(2083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 841, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(2421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 850, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.CreateTable(
                name: "CatalogItemDiscount",
                columns: table => new
                {
                    CatalogItemsId = table.Column<int>(type: "int", nullable: false),
                    DiscountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemDiscount", x => new { x.CatalogItemsId, x.DiscountsId });
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscount_catalogItems_CatalogItemsId",
                        column: x => x.CatalogItemsId,
                        principalTable: "catalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogItemDiscount_Discounts_DiscountsId",
                        column: x => x.DiscountsId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemDiscount_DiscountsId",
                table: "CatalogItemDiscount",
                column: "DiscountsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemDiscount");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(5899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(4695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(1683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(3525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(9944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 544, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(8107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "catalogItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(6878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(5654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 841, DateTimeKind.Local).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 540, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 850, DateTimeKind.Local).AddTicks(9913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 52, 27, 543, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.CreateIndex(
                name: "IX_catalogItems_DiscountId",
                table: "catalogItems",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_catalogItems_Discounts_DiscountId",
                table: "catalogItems",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

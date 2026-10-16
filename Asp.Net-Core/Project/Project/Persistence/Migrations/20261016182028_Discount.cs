using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Discount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(5899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(4695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(1683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(3525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(8107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(3638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(4017));

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
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(5654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(2080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 841, DateTimeKind.Local).AddTicks(8230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 102, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 850, DateTimeKind.Local).AddTicks(9913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsePercentage = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequiresCouponCode = table.Column<bool>(type: "bit", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountTypeId = table.Column<int>(type: "int", nullable: false),
                    LimitationTimes = table.Column<int>(type: "int", nullable: false),
                    DiscountLimitationId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(9944)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_catalogItems_Discounts_DiscountId",
                table: "catalogItems");

            migrationBuilder.DropTable(
                name: "Discounts");

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
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(2653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(9807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 110, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 852, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(8122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(4017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(6935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(2457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 851, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 102, DateTimeKind.Local).AddTicks(722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 841, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 16, 12, 34, 41, 109, DateTimeKind.Local).AddTicks(598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 16, 21, 50, 27, 850, DateTimeKind.Local).AddTicks(9913));
        }
    }
}

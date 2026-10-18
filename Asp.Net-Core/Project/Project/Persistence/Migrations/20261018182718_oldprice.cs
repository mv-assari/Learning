using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class oldprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(9033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(7836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(6601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(1762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(9912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(5203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.AddColumn<int>(
                name: "OldPrice",
                table: "catalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PercentDiscount",
                table: "catalogItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(7441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(3689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 273, DateTimeKind.Local).AddTicks(6894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 612, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(2308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.CreateTable(
                name: "DiscountUsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountUsageHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountUsageHistories_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountUsageHistories_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountUsageHistories_DiscountId",
                table: "DiscountUsageHistories",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountUsageHistories_OrderId",
                table: "DiscountUsageHistories",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscountUsageHistories");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "catalogItems");

            migrationBuilder.DropColumn(
                name: "PercentDiscount",
                table: "catalogItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(9675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(8402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(4790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(7159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 617, DateTimeKind.Local).AddTicks(2004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 278, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(9697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(3483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(8246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(1765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 612, DateTimeKind.Local).AddTicks(1746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 273, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 17, 21, 21, 1, 616, DateTimeKind.Local).AddTicks(273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 21, 57, 18, 277, DateTimeKind.Local).AddTicks(2308));
        }
    }
}

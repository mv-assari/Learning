using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CatalogItemComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(7926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(6538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(2171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(9572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(7676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(7531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(9287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(6302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(5013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(3833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(7257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 513, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 241, DateTimeKind.Local).AddTicks(4304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 510, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(5742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 513, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.CreateTable(
                name: "CatalogItemComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(2456)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItemComments_catalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "catalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemComments_CatalogItemId",
                table: "CatalogItemComments",
                column: "CatalogItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemComments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(7335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(6088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(1793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 515, DateTimeKind.Local).AddTicks(4507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 246, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(9304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(1067),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(6211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(4990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFavourites",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 514, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 245, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 513, DateTimeKind.Local).AddTicks(9298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 510, DateTimeKind.Local).AddTicks(6801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 241, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 20, 14, 19, 27, 513, DateTimeKind.Local).AddTicks(7815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 20, 15, 19, 46, 244, DateTimeKind.Local).AddTicks(5742));
        }
    }
}

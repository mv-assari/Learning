using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class favourite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(8431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(7108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(5903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(3294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(7799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(6591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(1597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 618, DateTimeKind.Local).AddTicks(7752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 76, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.CreateTable(
                name: "CatalogItemFavourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogItemId = table.Column<int>(type: "int", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(5506)),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemoveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItemFavourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogItemFavourites_catalogItems_CatalogItemId",
                        column: x => x.CatalogItemId,
                        principalTable: "catalogItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogItemFavourites_CatalogItemId",
                table: "CatalogItemFavourites",
                column: "CatalogItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItemFavourites");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "UserAddresses",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(7877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "payments",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(6694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(3243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(5903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Discounts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 81, DateTimeKind.Local).AddTicks(909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 623, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogType",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(9138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "catalogItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(4303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemImage",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(7795),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogItemFeature",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(6504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "CatalogBrand",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(2684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "Baskets",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 76, DateTimeKind.Local).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 618, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InsertTime",
                table: "BasketItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2026, 10, 18, 22, 8, 18, 80, DateTimeKind.Local).AddTicks(1207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2026, 10, 18, 22, 55, 15, 622, DateTimeKind.Local).AddTicks(219));
        }
    }
}

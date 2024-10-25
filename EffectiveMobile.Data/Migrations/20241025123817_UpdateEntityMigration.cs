using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EffectiveMobile.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OredersRegion");

            migrationBuilder.AddColumn<long>(
                name: "DeliveryLocationId",
                table: "Oreders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RegionId",
                table: "Oreders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Oreders_DeliveryLocationId",
                table: "Oreders",
                column: "DeliveryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Oreders_RegionId",
                table: "Oreders",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oreders_DeliveryLocations_DeliveryLocationId",
                table: "Oreders",
                column: "DeliveryLocationId",
                principalTable: "DeliveryLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Oreders_Region_RegionId",
                table: "Oreders",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oreders_DeliveryLocations_DeliveryLocationId",
                table: "Oreders");

            migrationBuilder.DropForeignKey(
                name: "FK_Oreders_Region_RegionId",
                table: "Oreders");

            migrationBuilder.DropIndex(
                name: "IX_Oreders_DeliveryLocationId",
                table: "Oreders");

            migrationBuilder.DropIndex(
                name: "IX_Oreders_RegionId",
                table: "Oreders");

            migrationBuilder.DropColumn(
                name: "DeliveryLocationId",
                table: "Oreders");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Oreders");

            migrationBuilder.CreateTable(
                name: "OredersRegion",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeliveryLocationId = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    RegionId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAtt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAtt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OredersRegion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OredersRegion_DeliveryLocations_DeliveryLocationId",
                        column: x => x.DeliveryLocationId,
                        principalTable: "DeliveryLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OredersRegion_Oreders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Oreders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OredersRegion_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OredersRegion_DeliveryLocationId",
                table: "OredersRegion",
                column: "DeliveryLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_OredersRegion_OrderId",
                table: "OredersRegion",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OredersRegion_RegionId",
                table: "OredersRegion",
                column: "RegionId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobile.Data.Migrations
{
    /// <inheritdoc />
    public partial class RegionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oreders_Region_RegionId",
                table: "Oreders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regions");

            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Regions",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_OrderId",
                table: "Regions",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oreders_Regions_RegionId",
                table: "Oreders",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Oreders_OrderId",
                table: "Regions",
                column: "OrderId",
                principalTable: "Oreders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oreders_Regions_RegionId",
                table: "Oreders");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Oreders_OrderId",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_OrderId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Regions");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Region");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Oreders_Region_RegionId",
                table: "Oreders",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

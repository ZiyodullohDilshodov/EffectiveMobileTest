using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobile.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEntityOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Oreders_OrderId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_OrderId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Regions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Regions",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_OrderId",
                table: "Regions",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Oreders_OrderId",
                table: "Regions",
                column: "OrderId",
                principalTable: "Oreders",
                principalColumn: "Id");
        }
    }
}

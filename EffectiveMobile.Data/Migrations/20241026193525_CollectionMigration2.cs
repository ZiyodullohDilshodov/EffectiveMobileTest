using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EffectiveMobile.Data.Migrations
{
    /// <inheritdoc />
    public partial class CollectionMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Region",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Region_OrderId",
                table: "Region",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Region_Oreders_OrderId",
                table: "Region",
                column: "OrderId",
                principalTable: "Oreders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Region_Oreders_OrderId",
                table: "Region");

            migrationBuilder.DropIndex(
                name: "IX_Region_OrderId",
                table: "Region");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Region");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestChallenge.Migrations
{
    /// <inheritdoc />
    public partial class ChangeStrucutreOFModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckoutId",
                table: "Totals");

            migrationBuilder.AddColumn<int>(
                name: "TotalId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_TotalId",
                table: "Carts",
                column: "TotalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Totals_TotalId",
                table: "Carts",
                column: "TotalId",
                principalTable: "Totals",
                principalColumn: "TotalId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Totals_TotalId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_TotalId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "TotalId",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "CheckoutId",
                table: "Totals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestChallenge.Migrations
{
    /// <inheritdoc />
    public partial class ChangeForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Totals_Carts_CartId",
                table: "Totals");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Totals",
                newName: "CheckoutId");

            migrationBuilder.RenameIndex(
                name: "IX_Totals_CartId",
                table: "Totals",
                newName: "IX_Totals_CheckoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Totals_Carts_CheckoutId",
                table: "Totals",
                column: "CheckoutId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Totals_Carts_CheckoutId",
                table: "Totals");

            migrationBuilder.RenameColumn(
                name: "CheckoutId",
                table: "Totals",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Totals_CheckoutId",
                table: "Totals",
                newName: "IX_Totals_CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Totals_Carts_CartId",
                table: "Totals",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

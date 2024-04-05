using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestChallenge.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDataType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Totals_Carts_CheckoutId",
                table: "Totals");

            migrationBuilder.DropIndex(
                name: "IX_Totals_CheckoutId",
                table: "Totals");

            migrationBuilder.RenameColumn(
                name: "CheckoutId",
                table: "Totals",
                newName: "Carts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Carts",
                table: "Totals",
                newName: "CheckoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Totals_CheckoutId",
                table: "Totals",
                column: "CheckoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Totals_Carts_CheckoutId",
                table: "Totals",
                column: "CheckoutId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

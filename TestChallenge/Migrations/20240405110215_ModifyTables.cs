using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestChallenge.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Totals_TotalId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_TotalId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "TotalId",
                table: "Carts",
                newName: "CheckoutId");

            migrationBuilder.AddColumn<int>(
                name: "CheckoutId",
                table: "Totals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckoutId",
                table: "Totals");

            migrationBuilder.RenameColumn(
                name: "CheckoutId",
                table: "Carts",
                newName: "TotalId");

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
    }
}

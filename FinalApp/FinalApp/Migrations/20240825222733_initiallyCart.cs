using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalApp.Migrations
{
    /// <inheritdoc />
    public partial class initiallyCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemIds",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Counter",
                table: "Carts",
                newName: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Carts",
                newName: "Counter");

            migrationBuilder.AddColumn<string>(
                name: "ItemIds",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

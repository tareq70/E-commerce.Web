using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_commerce.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductBrandNameProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductBrands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductBrands");
        }
    }
}

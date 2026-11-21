using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HairSalonManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoriteStylist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FavoriteStylistId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteStylistId",
                table: "AspNetUsers");
        }
    }
}

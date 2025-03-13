using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddPdfAndCoverImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PdfUrl",
                table: "FreeEBooks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PdfUrl",
                table: "FreeEBooks");
        }
    }
}

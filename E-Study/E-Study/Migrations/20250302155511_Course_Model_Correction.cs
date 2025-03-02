using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Study.Migrations
{
    /// <inheritdoc />
    public partial class Course_Model_Correction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YouTubeUrl",
                table: "Courses",
                newName: "YouTubeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YouTubeId",
                table: "Courses",
                newName: "YouTubeUrl");
        }
    }
}

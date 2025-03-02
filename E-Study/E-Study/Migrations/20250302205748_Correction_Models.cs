using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Study.Migrations
{
    /// <inheritdoc />
    public partial class Correction_Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ResultTime",
                table: "CourseResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultTime",
                table: "CourseResults");
        }
    }
}

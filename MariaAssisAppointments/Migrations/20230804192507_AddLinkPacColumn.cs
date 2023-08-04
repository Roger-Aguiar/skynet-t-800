using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MariaAssisAppointments.Migrations
{
    /// <inheritdoc />
    public partial class AddLinkPacColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkPac",
                table: "User",
                type: "longtext",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkPac",
                table: "User");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack_Task.Migrations
{
    public partial class AddingPositionToTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Trainers");
        }
    }
}

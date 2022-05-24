using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack_Task.Migrations
{
    public partial class AddingLinksToTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Trainers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Trainers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Trainers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "Trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Trainers");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "Trainers");
        }
    }
}

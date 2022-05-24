using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack_Task.Migrations
{
    public partial class AddingImgToTrainers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Trainers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_Slider.Migrations
{
    public partial class AddColumntoSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Sliders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Sliders");
        }
    }
}

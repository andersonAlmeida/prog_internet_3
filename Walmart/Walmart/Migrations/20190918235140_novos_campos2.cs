using Microsoft.EntityFrameworkCore.Migrations;

namespace Walmart.Migrations
{
    public partial class novos_campos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CostumerSatisfaction",
                table: "Department",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CostumerSatisfaction",
                table: "Department",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

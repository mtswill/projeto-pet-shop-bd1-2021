using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarteiraTrabalho",
                table: "Funcionario",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarteiraTrabalho",
                table: "Funcionario");
        }
    }
}

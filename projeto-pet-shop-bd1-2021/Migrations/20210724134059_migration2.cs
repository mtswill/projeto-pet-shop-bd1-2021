using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnderecoCep",
                table: "Pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoCidade",
                table: "Pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoComplemento",
                table: "Pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoEstado",
                table: "Pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoLogradouro",
                table: "Pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoNumero",
                table: "Pessoa",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoCep",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoCidade",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoComplemento",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoEstado",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoLogradouro",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EnderecoNumero",
                table: "Pessoa");
        }
    }
}

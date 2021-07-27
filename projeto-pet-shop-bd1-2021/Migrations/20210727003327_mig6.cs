using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Cliente_ClienteId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Funcionario_FuncionarioId",
                table: "Atendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_PessoaId",
                table: "Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_PessoaId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "PessoaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Cliente_ClienteId",
                table: "Animal",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Funcionario_FuncionarioId",
                table: "Atendimento",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Cliente_ClienteId",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Funcionario_FuncionarioId",
                table: "Atendimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Funcionario",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Cliente",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionario",
                table: "Funcionario",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_PessoaId",
                table: "Funcionario",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PessoaId",
                table: "Cliente",
                column: "PessoaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Cliente_ClienteId",
                table: "Animal",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Funcionario_FuncionarioId",
                table: "Atendimento",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

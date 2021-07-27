using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cpf = table.Column<string>(type: "text", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EnderecoLogradouro = table.Column<string>(type: "text", nullable: true),
                    EnderecoNumero = table.Column<string>(type: "text", nullable: true),
                    EnderecoComplemento = table.Column<string>(type: "text", nullable: true),
                    EnderecoCep = table.Column<string>(type: "text", nullable: true),
                    EnderecoCidade = table.Column<string>(type: "text", nullable: true),
                    EnderecoEstado = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Custo = table.Column<decimal>(type: "numeric", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    PessoaId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    PessoaId = table.Column<long>(type: "bigint", nullable: false),
                    CarteiraTrabalho = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Funcionario_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Caracteristica = table.Column<string>(type: "text", nullable: true),
                    TipoAnimalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Raca_TipoAnimal_TipoAnimalId",
                        column: x => x.TipoAnimalId,
                        principalTable: "TipoAnimal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    RacaId = table.Column<long>(type: "bigint", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Atendimento",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataHora = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AnimalId = table.Column<long>(type: "bigint", nullable: false),
                    FuncionarioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atendimento_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Atendimento_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicoAtendimento",
                columns: table => new
                {
                    AtendimentoId = table.Column<long>(type: "bigint", nullable: false),
                    ServicoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ServicoAtendimento_Atendimento_AtendimentoId",
                        column: x => x.AtendimentoId,
                        principalTable: "Atendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoAtendimento_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_ClienteId",
                table: "Animal",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_RacaId",
                table: "Animal",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_AnimalId",
                table: "Atendimento",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_FuncionarioId",
                table: "Atendimento",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Raca_TipoAnimalId",
                table: "Raca",
                column: "TipoAnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoAtendimento_AtendimentoId",
                table: "ServicoAtendimento",
                column: "AtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoAtendimento_ServicoId",
                table: "ServicoAtendimento",
                column: "ServicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicoAtendimento");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "TipoAnimal");
        }
    }
}

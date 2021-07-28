using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_pet_shop_bd1_2021.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ServicoId",
                table: "Atendimento",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Atendimento_ServicoId",
                table: "Atendimento",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimento_Servico_ServicoId",
                table: "Atendimento",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimento_Servico_ServicoId",
                table: "Atendimento");

            migrationBuilder.DropIndex(
                name: "IX_Atendimento_ServicoId",
                table: "Atendimento");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "Atendimento");
        }
    }
}

using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    [Table("atendimento")]
    public class Atendimento
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("data_hora")]
        public DateTime DataHora { get; set; }

        [ForeignKey("animal_id")]
        public long AnimalId { get; set; }

        [ForeignKey("funcionario_id")]
        public long FuncionarioId { get; set; }

        public Animal Animal { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
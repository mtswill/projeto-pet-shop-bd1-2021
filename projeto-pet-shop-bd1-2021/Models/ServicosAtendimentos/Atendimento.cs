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

        [ForeignKey("id_animal")]
        public long IdAnimal { get; set; }

        [ForeignKey("id_funcionario")]
        public long IdFuncionario { get; set; }
    }
}
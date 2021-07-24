using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class Atendimento : BaseEntity
    {
        public DateTime DataHora { get; set; }

        [ForeignKey("AnimalId")]
        public long AnimalId { get; set; }

        [ForeignKey("FuncionarioId")]
        public long FuncionarioId { get; set; }

        public Animal Animal { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
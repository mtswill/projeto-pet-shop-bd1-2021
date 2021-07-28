using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class Atendimento : BaseEntity
    {
        [Display(Name = "Data e hora")]
        public DateTime DataHora { get; set; }

        [Display(Name = "Animal")]
        [ForeignKey("AnimalId")]
        public long AnimalId { get; set; }

        [Display(Name = "Funcionario")]
        [ForeignKey("FuncionarioId")]
        public long FuncionarioId { get; set; }

        [Display(Name = "Servico")]
        [ForeignKey("ServicoId")]
        public long ServicoId { get; set; }

        public Animal Animal { get; set; }
        public Funcionario Funcionario { get; set; }
        public Servico Servico { get; set; }
    }
}
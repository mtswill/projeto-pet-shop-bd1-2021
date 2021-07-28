using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    public class Cliente
    {
        public long Id { get; set; }

        [Display(Name = "Pessoa")]
        [ForeignKey("PessoaId")]
        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
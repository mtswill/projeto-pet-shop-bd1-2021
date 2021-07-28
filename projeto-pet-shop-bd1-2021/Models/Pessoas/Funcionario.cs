using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    public class Funcionario
    {
        public long Id { get; set; }

        [Display(Name = "Pessoa")]
        [ForeignKey("PessoaId")]
        public long PessoaId { get; set; }

        [Display(Name = "Carteira de trabalho")]
        public string CarteiraTrabalho { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
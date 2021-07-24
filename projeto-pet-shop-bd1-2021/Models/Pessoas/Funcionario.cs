using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    public class Funcionario : BaseEntity
    {
        [ForeignKey("PessoaId")]
        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
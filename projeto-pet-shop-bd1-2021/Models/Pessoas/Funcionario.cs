using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Column("id")]
        public long Id { get; set; }

        [ForeignKey("pessoa_id")]
        public long PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
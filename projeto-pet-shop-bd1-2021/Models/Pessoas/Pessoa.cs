using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    [Table("pessoa")]
    public class Pessoa
    {
        public long Id { get; set; }
        public string Cpf { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
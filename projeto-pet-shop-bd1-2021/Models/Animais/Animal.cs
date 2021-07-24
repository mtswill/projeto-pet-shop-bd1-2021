using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    [Table("animal")]
    public class Animal
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        [ForeignKey("RacaId")]
        public long RacaId { get; set; }

        public long ClienteId { get; set; }

        public Raca Raca { get; set; }
        public Cliente Cliente { get; set; }
    }
}
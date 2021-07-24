using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Animal : BaseEntity
    {
        public string Nome { get; set; }

        [ForeignKey("RacaId")]
        public long RacaId { get; set; }

        public long ClienteId { get; set; }

        public Raca Raca { get; set; }
        public Cliente Cliente { get; set; }
    }
}
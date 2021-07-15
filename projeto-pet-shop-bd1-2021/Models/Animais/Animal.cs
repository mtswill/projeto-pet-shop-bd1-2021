using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    [Table("animal")]
    public class Animal
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [ForeignKey("raca_id")]
        public long RacaId { get; set; }

        [ForeignKey("cliente_id")]
        public long ClienteId { get; set; }

        public Raca Raca { get; set; }
        public Cliente Cliente { get; set; }
    }
}
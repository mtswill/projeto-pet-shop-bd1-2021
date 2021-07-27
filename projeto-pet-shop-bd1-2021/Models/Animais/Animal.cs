using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Animal : BaseEntity
    {
        public string Nome { get; set; }

        [Display(Name = "Raça")]
        [ForeignKey("RacaId")]
        public long RacaId { get; set; }

        [Display(Name = "ID do cliente")]
        public long ClienteId { get; set; }

        public Raca Raca { get; set; }
        public Cliente Cliente { get; set; }
    }
}
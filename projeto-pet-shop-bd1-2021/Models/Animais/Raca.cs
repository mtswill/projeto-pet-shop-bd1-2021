using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Raca : BaseEntity
    {
        public string Descricao { get; set; }

        public string Caracteristica { get; set; }

        [ForeignKey("TipoAnimalId")]
        public long TipoAnimalId { get; set; }

        public TipoAnimal TipoAnimal { get; set; }
    }
}
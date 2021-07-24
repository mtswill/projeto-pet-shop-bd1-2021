using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    [Table("raca")]
    public class Raca
    {
        public long Id { get; set; }

        public string Descricao { get; set; }

        public string Caracteristica { get; set; }

        [ForeignKey("TipoAnimalId")]
        public long TipoAnimalId { get; set; }

        public TipoAnimal TipoAnimal { get; set; }
    }
}
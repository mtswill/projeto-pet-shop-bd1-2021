using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Raca : BaseEntity
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Característica")]
        public string Caracteristica { get; set; }

        [Display(Name = "Tipo animal")]
        [ForeignKey("TipoAnimalId")]
        public long TipoAnimalId { get; set; }

        [Display(Name = "Tipo animal")]
        public TipoAnimal TipoAnimal { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    [Table("raca")]
    public class Raca
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("decricao")]
        public string Descricao { get; set; }

        [Column("caracteristica")]
        public string Caracteristica { get; set; }

        [ForeignKey("tipo_animal_id")]
        public long TipoAnimalId { get; set; }

        public TipoAnimal TipoAnimal { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    [Table("tipo_animal")]
    public class TipoAnimal
    {
        public long Id { get; set; }

        public string Descricao { get; set; }
    }
}
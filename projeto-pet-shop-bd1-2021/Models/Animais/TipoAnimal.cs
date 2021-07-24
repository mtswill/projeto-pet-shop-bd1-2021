using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class TipoAnimal : BaseEntity
    {
        public string Descricao { get; set; }
    }
}
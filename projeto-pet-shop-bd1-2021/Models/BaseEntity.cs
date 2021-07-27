using System.ComponentModel.DataAnnotations;

namespace projeto_pet_shop_bd1_2021.Models
{
    public class BaseEntity
    {
        [Display(Name = "ID")]
        [Key]
        public long Id { get; set; }
    }
}

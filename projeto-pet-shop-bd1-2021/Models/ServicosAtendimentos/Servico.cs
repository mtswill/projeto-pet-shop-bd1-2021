using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class Servico : BaseEntity
    {
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Custo")]
        public decimal Custo { get; set; }

        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
    }
}
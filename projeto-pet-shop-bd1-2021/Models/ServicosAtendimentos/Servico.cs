using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class Servico : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Valor { get; set; }
    }
}
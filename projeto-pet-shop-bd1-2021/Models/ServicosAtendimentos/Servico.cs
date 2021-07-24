using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    [Table("servico")]
    public class Servico
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Valor { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    [Table("servico")]
    public class Servico
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("custo")]
        public decimal Custo { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }
    }
}
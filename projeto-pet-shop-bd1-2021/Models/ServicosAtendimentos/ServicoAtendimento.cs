using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    [Table("servico_atendimento")]
    public class ServicoAtendimento
    {
        [ForeignKey("id_atendimento")]
        public long IdAtendimento { get; set; }

        [ForeignKey("id_servico")]
        public long IdServico { get; set; }

        public Atendimento Atendimento { get; set; }
        public List<Servico> Servico { get; set; }
    }
}

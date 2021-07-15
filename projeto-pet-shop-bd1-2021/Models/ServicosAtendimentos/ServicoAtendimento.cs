using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    [Table("servico_atendimento")]
    public class ServicoAtendimento
    {
        [ForeignKey("atendimento_id")]
        public long AtendimentoId { get; set; }

        [ForeignKey("servico_id")]
        public long ServicoId { get; set; }

        public Atendimento Atendimento { get; set; }
        public Servico Servico { get; set; }
    }
}

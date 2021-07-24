using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class ServicoAtendimento
    {
        [ForeignKey("AtendimentoId")]
        public long AtendimentoId { get; set; }

        [ForeignKey("ServicoId")]
        public long ServicoId { get; set; }

        public Atendimento Atendimento { get; set; }
        public Servico Servico { get; set; }
    }
}

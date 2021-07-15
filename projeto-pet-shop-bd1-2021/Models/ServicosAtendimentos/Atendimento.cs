using System;

namespace projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos
{
    public class Atendimento
    {
        public long Id { get; set; }
        public DateTime DataHora { get; set; }
        public long IdAnimal { get; set; }
        public long IdFuncionario { get; set; }
    }
}
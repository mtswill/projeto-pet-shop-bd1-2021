using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class AtendimentoViewModel
    {
        public AtendimentoViewModel(List<Servico> servico, List<Animal> animal, List<Funcionario> funcionario)
        {
            Servico = servico;
            Animal = animal;
            Funcionario = funcionario;
        }

        public AtendimentoViewModel(Atendimento atendimento, List<Servico> servico, List<Animal> animal, List<Funcionario> funcionario)
        {
            Atendimento = atendimento;
            Servico = servico;
            Animal = animal;
            Funcionario = funcionario;
        }

        public Atendimento Atendimento { get; set; }
        public List<Servico> Servico { get; set; }
        public List<Animal> Animal { get; set; }
        public List<Funcionario> Funcionario { get; set; }
    }
}

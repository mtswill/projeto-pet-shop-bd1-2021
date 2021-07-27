using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.Collections.Generic;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class FuncionarioViewModel
    {
        public FuncionarioViewModel(ICollection<Pessoa> pessoa)
        {
            Pessoa = pessoa;
        }

        public Funcionario Funcionario { get; set; }
        public ICollection<Pessoa> Pessoa { get; set; }
    }
}

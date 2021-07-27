using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.Collections.Generic;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel(ICollection<Pessoa> pessoa)
        {
            Pessoa = pessoa;
        }

        public Cliente Cliente { get; set; }
        public ICollection<Pessoa> Pessoa { get; set; }
    }
}

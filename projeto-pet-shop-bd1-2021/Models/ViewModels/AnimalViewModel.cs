using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class AnimalViewModel
    {
        public AnimalViewModel(ICollection<Raca> raca, ICollection<Cliente> cliente)
        {
            Raca = raca;
            Cliente = cliente;
        }
        
        public AnimalViewModel(ICollection<Raca> raca, ICollection<Cliente> cliente, Animal animal)
        {
            Raca = raca;
            Cliente = cliente;
            Animal = animal;
        }

        public Animal Animal { get; set; }
        public ICollection<Raca> Raca { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
    }
}

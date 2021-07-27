using projeto_pet_shop_bd1_2021.Models.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class AnimalViewModel
    {
        public AnimalViewModel(ICollection<Raca> raca)
        {
            Raca = raca;
        }

        public Animal Animal { get; set; }
        public ICollection<Raca> Raca { get; set; }
    }
}

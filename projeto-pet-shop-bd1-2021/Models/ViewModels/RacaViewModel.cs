using projeto_pet_shop_bd1_2021.Models.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Models.ViewModels
{
    public class RacaViewModel
    {
        public RacaViewModel(Raca raca, ICollection<TipoAnimal> tipoAnimal)
        {
            Raca = raca;
            TipoAnimal = tipoAnimal;
        }

        public RacaViewModel(ICollection<TipoAnimal> tipoAnimal)
        {
            TipoAnimal = tipoAnimal;
        }

        public Raca Raca { get; set; }
        public ICollection<TipoAnimal> TipoAnimal { get; set; }
    }
}

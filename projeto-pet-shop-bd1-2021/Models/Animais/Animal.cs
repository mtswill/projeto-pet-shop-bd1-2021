using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Animal
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long IdRaca { get; set; }
    }
}

using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System.Collections.Generic;

namespace projeto_pet_shop_bd1_2021.Controllers
{
    internal class funcionarioviewmodel
    {
        private List<Pessoa> pessoas;

        public funcionarioviewmodel(List<Pessoa> pessoas)
        {
            this.pessoas = pessoas;
        }
    }
}
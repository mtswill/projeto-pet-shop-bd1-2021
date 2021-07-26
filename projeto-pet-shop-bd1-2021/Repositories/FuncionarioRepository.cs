using projeto_pet_shop_bd1_2021.Data;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private PetShopContext _context;

        public FuncionarioRepository(PetShopContext context)
        {
            _context = context;
        }

        public Funcionario Create(Funcionario item)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long id)
        {
            throw new NotImplementedException();
        }

        public Funcionario FindById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Funcionario Update(Funcionario item)
        {
            throw new NotImplementedException();
        }
    }
}

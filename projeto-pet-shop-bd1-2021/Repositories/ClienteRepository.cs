using projeto_pet_shop_bd1_2021.Data;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private PetShopContext _context;

        public ClienteRepository(PetShopContext context)
        {
            _context = context;
        }

        public Cliente Create(Cliente item)
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

        public Cliente FindById(long id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente Update(Cliente item)
        {
            throw new NotImplementedException();
        }
    }
}

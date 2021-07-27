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
            try
            {
                _context.Cliente.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            var result = _context.Cliente.SingleOrDefault(p => p.PessoaId.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Cliente.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
            => _context.Cliente.Any(p => p.PessoaId.Equals(id));

        public Cliente FindById(long id)
            => _context.Cliente.SingleOrDefault(p => p.PessoaId.Equals(id));

        public List<Cliente> GetAll()
            => _context.Cliente.ToList();

        public Cliente Update(Cliente item)
        {
            var result = _context.Cliente.SingleOrDefault(p => p.PessoaId.Equals(item.PessoaId));

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }
    }
}

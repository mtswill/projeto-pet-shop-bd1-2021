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
            try
            {
                _context.Funcionario.Add(item);
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
            var result = _context.Funcionario.SingleOrDefault(p => p.PessoaId.Equals(id));

            if (result != null)
            {
                try
                {
                    _context.Funcionario.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
            => _context.Funcionario.Any(p => p.PessoaId.Equals(id));

        public Funcionario FindById(long id)
            => _context.Funcionario.SingleOrDefault(p => p.PessoaId.Equals(id));

        public List<Funcionario> GetAll()
            => _context.Funcionario.ToList();

        public Funcionario Update(Funcionario item)
        {
            var result = _context.Funcionario.SingleOrDefault(p => p.PessoaId.Equals(item.PessoaId));

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

using projeto_pet_shop_bd1_2021.Data;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private GenericRepository<Pessoa> _repository;
        private PetShopContext _context;

        public PessoaRepository(GenericRepository<Pessoa> repository, PetShopContext context)
        {
            _repository = repository;
            _context = context;
        }

        public Pessoa Create(Pessoa item)
            => _repository.Create(item);

        public void Delete(long id)
            => _repository.Delete(id);

        public bool Exists(long id)
            => _repository.Exists(id);

        public Pessoa FindById(long id)
            => _repository.FindById(id);

        public List<Pessoa> GetAll()
            => _repository.GetAll();

        public Pessoa Update(Pessoa item)
            => _repository.Update(item);

        public Pessoa FindByCpf(string cpf)
            => _context.Pessoa.SingleOrDefault(p => p.Cpf.Equals(cpf));
    }
}

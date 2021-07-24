using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Repositories
{
    interface IGenericRepository<T>
    {
        public T Create(T item);
        T FindById(long id);
        List<T> GetAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}

using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using projeto_pet_shop_bd1_2021.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers
{
    public class PessoaController : Controller
    {
        private GenericRepository<Pessoa> _repository;

        public PessoaController(GenericRepository<Pessoa> repository)
        {
            _repository = repository;
        }

        #region Views

        public IActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(pessoa);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

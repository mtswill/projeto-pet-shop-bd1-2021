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
        private PessoaRepository _repository;

        public PessoaController(PessoaRepository repository)
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
        
        public IActionResult Details(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }
        
        public IActionResult Edit(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }
        
        public IActionResult Delete(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
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
                return RedirectToAction(nameof(Details), new { id = pessoa.Id });
            }

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(pessoa);
                return RedirectToAction(nameof(Details), new { id = pessoa.Id });
            }

            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(long? id)
        {
            if (id != null)
            {
                _repository.Delete((long)id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers.AnimalController
{
    public class TipoAnimalController : Controller
    {
        private GenericRepository<TipoAnimal> _repository;

        public TipoAnimalController(GenericRepository<TipoAnimal> repository)
        {
            _repository = repository;
        }

        #region Views

        public ActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }

        public ActionResult Details(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }

        public ActionResult Delete(long id)
        {
            var model = _repository.FindById(id);
            return View(model);
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoAnimal tipo)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(tipo);
                return RedirectToAction(nameof(Details), new { id = tipo.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoAnimal tipo)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(tipo);
                return RedirectToAction(nameof(Details), new { id = tipo.Id });
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

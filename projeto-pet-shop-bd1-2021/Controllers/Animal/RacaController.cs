using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.ViewModels;
using projeto_pet_shop_bd1_2021.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers.AnimalController
{
    public class RacaController : Controller
    {
        private GenericRepository<Raca> _repository;
        private GenericRepository<TipoAnimal> _repositoryTipoAnimal;

        public RacaController(GenericRepository<Raca> repository, GenericRepository<TipoAnimal> repositoryTipoAnimal)
        {
            _repository = repository;
            _repositoryTipoAnimal = repositoryTipoAnimal;
        }

        #region Views

        public ActionResult Index()
        {
            var model = _repository.GetAll();

            foreach (var item in model)
            {
                item.TipoAnimal = _repositoryTipoAnimal.FindById(item.TipoAnimalId);
            }

            return View(model);
        }

        public ActionResult Details(long id)
        {
            var model = _repository.FindById(id);
            model.TipoAnimal = _repositoryTipoAnimal.FindById(model.TipoAnimalId);
            return View(model);
        }

        public ActionResult Create()
        {
            var tiposAnimal = _repositoryTipoAnimal.GetAll();
            var model = new RacaViewModel(tiposAnimal);
            return View(model);
        }

        public ActionResult Edit(long id)
        {
            var raca = _repository.FindById(id);
            var tiposAnimal = _repositoryTipoAnimal.GetAll();
            raca.TipoAnimal = tiposAnimal.FirstOrDefault(r => r.Id.Equals(raca.TipoAnimalId));

            var model = new RacaViewModel(raca, tiposAnimal);

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
        public IActionResult Create(Raca raca)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(raca);
                return RedirectToAction(nameof(Details), new { id = raca.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Raca raca)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(raca);
                return RedirectToAction(nameof(Details), new { id = raca.Id });
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

using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Repositories;
using projeto_pet_shop_bd1_2021.Models.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_pet_shop_bd1_2021.Models.ViewModels;

namespace projeto_pet_shop_bd1_2021.Controllers.AnimalController
{
    public class AnimalController : Controller
    {
        private GenericRepository<Animal> _animalRepository;
        private GenericRepository<Raca> _racaRepository;
        private ClienteRepository _clienteRepository;

        public AnimalController(GenericRepository<Animal> animalRepository, GenericRepository<Raca> racaRepository, ClienteRepository clienteRepository)
        {
            _animalRepository = animalRepository;
            _racaRepository = racaRepository;
            _clienteRepository = clienteRepository;
        }

        #region Views

        public ActionResult Index()
        {
            var model = _animalRepository.GetAll();
            return View(model);
        }

        public ActionResult Details(long id)
        {
            var model = _animalRepository.FindById(id);
            return View(model);
        }

        public ActionResult Create()
        {
            var model = new AnimalViewModel(_racaRepository.GetAll(), _clienteRepository.GetAll());
            return View(model);
        }

        public ActionResult Edit(long id)
        {
            var animal = _animalRepository.FindById(id);
            var racas = _racaRepository.GetAll();
            var clientes = _clienteRepository.GetAll();

            animal.Raca = racas.FirstOrDefault(r => r.Id.Equals(animal.RacaId));
            animal.Cliente = clientes.FirstOrDefault(r => r.Id.Equals(animal.ClienteId));

            var model = new AnimalViewModel(racas, clientes, animal);
            return View(model);
        }

        public ActionResult Delete(long id)
        {
            var model = _animalRepository.FindById(id);
            return View(model);
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _animalRepository.Create(animal);
                return RedirectToAction(nameof(Details), new { id = animal.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _animalRepository.Update(animal);
                return RedirectToAction(nameof(Details), new { id = animal.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(long? id)
        {
            if (id != null)
            {
                _animalRepository.Delete((long)id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

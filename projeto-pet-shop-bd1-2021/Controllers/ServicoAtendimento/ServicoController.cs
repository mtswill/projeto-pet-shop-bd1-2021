using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Repositories;
using projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers.ServicoAtendimento
{
    public class ServicoController : Controller
    {
        private GenericRepository<Servico> _repository;

        public ServicoController(GenericRepository<Servico> repository)
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
        public IActionResult Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                _repository.Create(servico);
                return RedirectToAction(nameof(Details), new { id = servico.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Servico servico)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(servico);
                return RedirectToAction(nameof(Details), new { id = servico.Id });
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

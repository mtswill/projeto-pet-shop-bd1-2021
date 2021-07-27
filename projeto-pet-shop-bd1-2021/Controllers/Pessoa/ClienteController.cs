using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models;
using projeto_pet_shop_bd1_2021.Models.Pessoas;
using projeto_pet_shop_bd1_2021.Models.ViewModels;
using projeto_pet_shop_bd1_2021.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository _clienteRepository;
        private PessoaRepository _pessoaRepository;

        public ClienteController(ClienteRepository clienteRepository, PessoaRepository pessoaRepository)
        {
            _clienteRepository = clienteRepository;
            _pessoaRepository = pessoaRepository;
        }

        #region Views

        public IActionResult Index()
        {
            var model = _clienteRepository.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new ClienteViewModel(_pessoaRepository.GetAll()));
        }

        public IActionResult Details(long id)
        {
            var model = _clienteRepository.FindById(id);
            return View(model);
        }

        public IActionResult Edit(long id)
        {
            var model = _clienteRepository.FindById(id);
            return View(model);
        }

        public IActionResult Delete(long id)
        {
            var model = _clienteRepository.FindById(id);
            return View(model);
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                if (_pessoaRepository.Exists(cliente.PessoaId))
                {
                    if (_clienteRepository.Exists(cliente.PessoaId))
                    {
                        return RedirectToAction(nameof(Index), "Error", new ErrorViewModel("ID da pessoa já cadastrado como cliente."));
                    }

                    _clienteRepository.Create(cliente);
                    return RedirectToAction(nameof(Details), new { id = cliente.PessoaId });
                }
                else
                {
                    return RedirectToAction(nameof(Index), "Error", new ErrorViewModel("ID da pessoa não existe."));
                }
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Update(cliente);
                return RedirectToAction(nameof(Details), new { id = cliente.PessoaId });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(long? id)
        {
            if (id != null)
            {
                _clienteRepository.Delete((long)id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

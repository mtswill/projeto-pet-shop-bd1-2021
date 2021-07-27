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
    public class FuncionarioController : Controller
    {
        private FuncionarioRepository _funcionarioRepository;
        private PessoaRepository _pessoaRepository;

        public FuncionarioController(FuncionarioRepository funcionarioRepository, PessoaRepository pessoaRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _pessoaRepository = pessoaRepository;
        }

        #region Views

        public IActionResult Index()
        {
            var model = _funcionarioRepository.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View(new FuncionarioViewModel(_pessoaRepository.GetAll()));
        }

        public IActionResult Details(long id)
        {
            var model = _funcionarioRepository.FindById(id);
            return View(model);
        }

        public IActionResult Edit(long id)
        {
            var model = _funcionarioRepository.FindById(id);
            return View(model);
        }

        public IActionResult Delete(long id)
        {
            var model = _funcionarioRepository.FindById(id);
            return View(model);
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                if (_pessoaRepository.Exists(funcionario.PessoaId))
                {
                    if (_funcionarioRepository.Exists(funcionario.PessoaId))
                    {
                        return RedirectToAction(nameof(Index), "Error", new ErrorViewModel("ID da pessoa já cadastrado como funcionário."));
                    }

                    _funcionarioRepository.Create(funcionario);
                    return RedirectToAction(nameof(Details), new { id = funcionario.PessoaId });
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
        public IActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRepository.Update(funcionario);
                return RedirectToAction(nameof(Details), new { id = funcionario.PessoaId });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(long? id)
        {
            if (id != null)
            {
                _funcionarioRepository.Delete((long)id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

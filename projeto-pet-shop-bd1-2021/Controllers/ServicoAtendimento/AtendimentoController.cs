using Microsoft.AspNetCore.Mvc;
using projeto_pet_shop_bd1_2021.Models.Animais;
using projeto_pet_shop_bd1_2021.Models.ServicosAtendimentos;
using projeto_pet_shop_bd1_2021.Models.ViewModels;
using projeto_pet_shop_bd1_2021.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_pet_shop_bd1_2021.Controllers.ServicoAtendimento
{
    public class AtendimentoController : Controller
    {
        private GenericRepository<Atendimento> _atendimentoRepository;
        private GenericRepository<Servico> _servicoRepository;
        private GenericRepository<Animal> _animalRepository;
        private FuncionarioRepository _funcionarioRepository;

        public AtendimentoController(GenericRepository<Atendimento> atendimentoRepository, GenericRepository<Servico> servicoRepository, GenericRepository<Animal> animalRepository, FuncionarioRepository funcionarioRepository)
        {
            _atendimentoRepository = atendimentoRepository;
            _servicoRepository = servicoRepository;
            _animalRepository = animalRepository;
            _funcionarioRepository = funcionarioRepository;
        }

        #region Views

        public IActionResult Index()
        {
            var model = _atendimentoRepository.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            var animais = _animalRepository.GetAll();
            var servicos = _servicoRepository.GetAll();
            var funcionarios = _funcionarioRepository.GetAll();

            return View(new AtendimentoViewModel(servicos, animais, funcionarios));
        }

        public IActionResult Details(long id)
        {
            var atendimento = _atendimentoRepository.FindById(id);

            return View(atendimento);
        }

        public IActionResult Edit(long id)
        {
            var atendimento = _atendimentoRepository.FindById(id);
            var animais = _animalRepository.GetAll();
            var servicos = _servicoRepository.GetAll();
            var funcionarios = _funcionarioRepository.GetAll();

            atendimento.Animal = animais.FirstOrDefault(r => r.Id.Equals(atendimento.AnimalId));
            atendimento.Servico = servicos.FirstOrDefault(r => r.Id.Equals(atendimento.ServicoId));
            atendimento.Funcionario = funcionarios.FirstOrDefault(r => r.Id.Equals(atendimento.FuncionarioId));

            return View(new AtendimentoViewModel(atendimento, servicos, animais, funcionarios));
        }

        public IActionResult Delete(long id)
        {
            var model = _atendimentoRepository.FindById(id);
            return View(model);
        }

        #endregion Views

        #region Manipulação de dados

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                _atendimentoRepository.Create(atendimento);
                return RedirectToAction(nameof(Details), new { id = atendimento.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Atendimento atendimento)
        {
            if (ModelState.IsValid)
            {
                _atendimentoRepository.Update(atendimento);
                return RedirectToAction(nameof(Details), new { id = atendimento.Id });
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(long? id)
        {
            if (id != null)
            {
                _atendimentoRepository.Delete((long)id);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        #endregion Manipulação de dados
    }
}

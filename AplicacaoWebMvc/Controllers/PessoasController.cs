using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacaoWebMvc.Models;
using AplicacaoWebMvc.Models.ViewModels;
using AplicacaoWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWebMvc.Controllers
{
    public class PessoasController : Controller
    {

        // Injeção de dependencia para os meus servicos de pessoas
        private readonly ServicoPessoas _pessoaServico;

        private readonly ServicoFichario _servicoFichario;

        // Construtor para inicializar os servicos
        public PessoasController(ServicoPessoas pessoaServico, ServicoFichario servicoFichario)
        {
            _pessoaServico = pessoaServico;
            _servicoFichario = servicoFichario;
        }


        public IActionResult Index()
        {
            //Buscar uma lista de pessoas no banco
            var list = _pessoaServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            // carregando lista de fichas
            var fichario = _servicoFichario.FindAll();

            // instaciar onjetos do view model

            var viewModel = new PessoaFormViewModel { Ficharios = fichario };

            

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pessoa pessoa)
        {
            _pessoaServico.Insert(pessoa);

            return RedirectToAction(nameof(Index));
        }
    }
}
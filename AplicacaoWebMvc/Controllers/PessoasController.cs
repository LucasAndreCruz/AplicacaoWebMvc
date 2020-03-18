using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacaoWebMvc.Models;
using AplicacaoWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWebMvc.Controllers
{
    public class PessoasController : Controller
    {

        // Injeção de dependencia para os meus servicos de pessoas
        private readonly ServicoPessoas _pessoaServico;

        // Construtor para inicializar os servicos
        public PessoasController(ServicoPessoas pessoaServico)
        {
            _pessoaServico = pessoaServico;
        }


        public IActionResult Index()
        {
            //Buscar uma lista de pessoas no banco
            var list = _pessoaServico.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
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
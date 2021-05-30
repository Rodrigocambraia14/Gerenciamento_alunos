using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sistema_turma.Models;

namespace Sistema_turma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
         public IActionResult Confirmacao(Aluno aluno)
        {
           switch(aluno.Turma)
           {
               case 1:
                List<Aluno> alunos1 = CadastroAluno.Listar1();
                if(alunos1.Capacity > 20)
                {
                    ViewBag.Mensagem="Limite de alunos atingido!";
                }
                else
                {
                    CadastroAluno.Incluir(aluno);
                }
               break;
                
               case 2:
                List<Aluno> alunos2 = CadastroAluno.Listar2();
                if(alunos2.Capacity > 20)
                {
                    ViewBag.Mensagem="Limite de alunos atingido!";
                }
                else
                {
                    CadastroAluno.Incluir(aluno);
                }
               break;

               case 3:
                List<Aluno> alunos3 = CadastroAluno.Listar3();
                if(alunos3.Capacity > 20)
                {
                    ViewBag.Mensagem="Limite de alunos atingido!";
                }
                else
                {
                    CadastroAluno.Incluir(aluno);
                }
               break;
           } 
           return View(aluno);
        }

    }
}

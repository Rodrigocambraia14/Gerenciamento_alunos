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

        public IActionResult Turma1()
        {
            int i = 0;
           object[] Turma1 = new object[20];
           
           for(i = 0; i < 20; i++)
           {
                Random randNum = new Random();
                Alunos aluno = new Alunos();

                aluno.Nome = "Aluno" + i;
                aluno.Nota1 = randNum.Next(10);
                aluno.Nota2 = randNum.Next(10);
                aluno.Nota3 = randNum.Next(10);
                aluno.Media = (float)((aluno.Nota1 + aluno.Nota2 * 1.2 + aluno.Nota2 * 1.4) / (1 + 1.2 + 1.4));
                //Situação de Aprovação
                if(aluno.Media > 6)
                {
                    aluno.MediaFinal = aluno.Media;
                     aluno.Mensagem = "APROVADO!";
                     aluno.MensagemFinal = aluno.Mensagem;
                }
                //situação de Prova Final
                else if(aluno.Media <=6 && aluno.Media > 4)
                {
                    
                    aluno.Mensagem = "EM RECUPERAÇÃO!";
                     aluno.NotaFinal = randNum.Next(10);
                     aluno.MediaFinal = (float)(aluno.Media + aluno.NotaFinal) / 2;
                     
                     if(aluno.MediaFinal >= 5)
                     {
                         aluno.MensagemFinal = "APROVADO!";
                     }
                     else{
                         aluno.MensagemFinal = "REPROVADO!";
                     }
                }
                // Situação de Reprovação
                else
                {
                    aluno.MediaFinal = aluno.Media;
                    aluno.Mensagem = "REPROVADO!";
                    aluno.MensagemFinal = aluno.Mensagem;
                }
                // guarda o objeto com os atributos em Turma1[]
                Turma1[i] = aluno;

                //Validação da competição
    
           }

            return View(Turma1);
        }
        public IActionResult Turma2()
        {
            int i = 0;
           object[] Turma2 = new object[20];
           
           for(i = 0; i < 20; i++)
           {
                Random randNum = new Random();
                Alunos aluno = new Alunos();

                aluno.Nome = "Aluno" + i;
                aluno.Nota1 = randNum.Next(10);
                aluno.Nota2 = randNum.Next(10);
                aluno.Nota3 = randNum.Next(10);
                aluno.Media = (float)((aluno.Nota1 + aluno.Nota2 * 1.2 + aluno.Nota2 * 1.4) / (1 + 1.2 + 1.4));
                //Situação de Aprovação
                if(aluno.Media > 6)
                {
                     aluno.MediaFinal = aluno.Media;
                     aluno.Mensagem = "APROVADO!";
                     aluno.MensagemFinal = aluno.Mensagem;
                }
                 //situação de Prova Final
                else if(aluno.Media <=6 && aluno.Media > 4)
                {
                    aluno.Mensagem = "EM RECUPERAÇÃO!";
                     aluno.NotaFinal = randNum.Next(10);
                     aluno.MediaFinal = (float)(aluno.Media + aluno.NotaFinal) / 2;
                     
                     if(aluno.MediaFinal >= 5)
                     {
                         aluno.MensagemFinal = "APROVADO!";
                     }
                     else{
                         aluno.MensagemFinal = "REPROVADO!";
                     }
                }
                // Situação de Reprovação
                else
                {
                    aluno.MediaFinal = aluno.Media;
                    aluno.Mensagem = "REPROVADO!";
                    aluno.MensagemFinal = aluno.Mensagem;
                }
               
                Turma2[i] = aluno;
           }
            return View(Turma2);
        }
        public IActionResult Turma3()
        {
            int i = 0;
           Object[] Turma3 = new Object[20];
           
           for(i = 0; i < 20; i++)
           {
            
                Alunos aluno = new Alunos();
                Random randNum = new Random();

                aluno.Nome = "Aluno " + i;
                aluno.Nota1 = randNum.Next(10);
                aluno.Nota2 = randNum.Next(10);
                aluno.Nota3 = randNum.Next(10);
                aluno.Media = (float)((aluno.Nota1 + aluno.Nota2 * 1.2 + aluno.Nota2 * 1.4) / (1 + 1.2 + 1.4));
                //Situação de Aprovação
                if(aluno.Media > 6)
                {
                     aluno.MediaFinal = aluno.Media;
                     aluno.Mensagem = "APROVADO!";
                     aluno.MensagemFinal = aluno.Mensagem;
                }
                //situação de Prova Final
                else if(aluno.Media <=6 && aluno.Media > 4)
                {
                     aluno.Mensagem = "EM RECUPERAÇÃO!";
                     aluno.NotaFinal = randNum.Next(10);
                     aluno.MediaFinal = (float)(aluno.Media + aluno.NotaFinal) / 2;
                     
                     if(aluno.MediaFinal >= 5)
                     {
                         aluno.MensagemFinal = "APROVADO!";
                     }
                     else{
                         aluno.MensagemFinal = "REPROVADO!";
                     }
                }
                // Situação de Reprovação
                else
                {
                    aluno.MediaFinal = aluno.Media;
                    aluno.Mensagem = "REPROVADO!";
                    aluno.MensagemFinal = aluno.Mensagem;
                }
                Turma3[i] = aluno;
            }
            return View(Turma3);
        }

    }
}

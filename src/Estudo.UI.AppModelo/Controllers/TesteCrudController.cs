using Estudo.UI.AppModelo.Data;
using Estudo.UI.AppModelo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo.UI.AppModelo.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext context)
        {
            _contexto = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Karollainny",
                DataNascimento = DateTime.Now,
                Email = "karol@mail.com"
            };
            //Criando
            _contexto.ALunos.Add(aluno);
            _contexto.SaveChanges();

            //Obtendo
            var alunoPorId = _contexto.ALunos.Find(aluno.Id);
            var alunoPorEmail = _contexto.ALunos.FirstOrDefault(a => a.Email == "karol@mail.com"); // retorna a primeira ocorrencia
            var alunos = _contexto.ALunos.Where(a => a.Nome == "Karol"); // retorna todas as ocorrencias

            //Atualizando
            aluno.Nome = "Karol Teles";
            _contexto.ALunos.Update(aluno);
            _contexto.SaveChanges();

            //Excluindo
            _contexto.ALunos.Remove(aluno);
            _contexto.SaveChanges();
            return View("_Layout");
            
        }
    }
}
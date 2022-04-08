using DevIO.UI.Site.Data;
using DevIO.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevIO.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Marquescharlon",
                DataNascimento = DateTime.Now,
                Email = "email@teste.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "email@teste.com");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Marquescharlon");

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            

            return View("_Layout");
        }
    }
}

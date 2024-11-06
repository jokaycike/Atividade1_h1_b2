using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Atividade1_h1_b2.Controllers
{
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(NovaDisciplina dados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool fliInseriu = _disciplinaService.Inserir(dados);

            if (fliInseriu) return Ok($"Disciplina {dados.Nome} inserido com sucesso");

            return BadRequest($"Disciplina {dados.Nome} não inserido");
        }

        [HttpGet]
        [Route("ObterTodasDisciplinas")]
        public IActionResult ObterTodasDisciplinas()
        {
            return Ok(_disciplinaService.obterTodasDisciplinas());
        }

    }
}

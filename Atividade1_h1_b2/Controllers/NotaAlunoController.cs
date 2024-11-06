using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Atividade1_h1_b2.Controllers
{
    [ApiController]
    [Route("api/notaAluno")]
    public class NotaAlunoController : ControllerBase
    {
        private readonly INotaAlunoService _notaAlunoService;
        public NotaAlunoController(INotaAlunoService notaAlunoService)
        {
            _notaAlunoService = notaAlunoService;
        }

        [HttpGet]
        [Route("Inserir")]
        public IActionResult Inserir(NovaNotaAluno nota)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _notaAlunoService.Inserir(nota);
                return Ok($"Nota para o aluno {nota.RaAluno} na discilina {nota.idDicipina} inserida");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao inserir nota: {ex.Message}");
            }

        }

        [HttpGet]
        [Route("ListaAprovados")]
        public IActionResult ListarAprovados()
        {
            var alunosAprovados = _notaAlunoService.ListaAlunosAprovados();
            return Ok(alunosAprovados);
        }

        [HttpGet]
        [Route("ListaReprovados")]
        public IActionResult ListarReprovados()
        {
            var alunosReprovados = _notaAlunoService.ListaAlunosReprovados();
            return Ok(alunosReprovados);
        }
    }
}

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
            if (!ModalState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _notaAlunoService.Inserir(nota);
        }
    }
    //inserir nota, listaAlunosAprovados, listaAlunosReprovads
}

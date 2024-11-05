using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Atividade1_h1_b2.Controllers
{
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir(NovoAluno dados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool flInseriu = _alunoService.Inserir(dados);

            if (flInseriu)
                return Ok($"Aluno(a) {dados.nome} inserido com sucesso.");

            return BadRequest($"Aluno(a) {dados.nome} não inserido, " +
                $"cpf ou ra já existe.");

        }

        [HttpGet]
        [Route("ObterPorCpf")]
        public IActionResult ObterPorCpf(string cpf)
        {
            var alunoPesquisado = _alunoService.obterAlunosPorCpf(cpf);

            if (alunoPesquisado is null)
                return NotFound($"Aluno com cpf {cpf} não encontrado.");

            return Ok(alunoPesquisado);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_alunoService.obterTodosAlunos());
        }


        [HttpGet]
        public IActionResult OlaAluno()
        {
            return Ok("Ola Mundo");
        }

        [HttpPost]
        public IActionResult OlaAlunoNome(string nome)
        {
            return Ok($"Ola Mundo {nome}");
        }
    }
}

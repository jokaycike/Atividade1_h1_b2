using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Services
{
    public interface IAlunoService
    {
        public List<DadosAluno> obterTodosAlunos();
        public DadosAluno obterAlunosPorCpf(string cpf);

        public DadosAluno obterAlunosPorRa(string ra);

        public bool Inserir(NovoAluno novoAluno);
    }
}

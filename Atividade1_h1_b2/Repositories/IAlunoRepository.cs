using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public interface IAlunoRepository
    {
        public List<DadosAluno> obterTodosAlunos();
        public DadosAluno obterAlunosPorCpf(string cpf);
        public DadosAluno obterAlunosPorRa(string ra);
        public void Inserir(NovoAluno novoAluno);
    }
}

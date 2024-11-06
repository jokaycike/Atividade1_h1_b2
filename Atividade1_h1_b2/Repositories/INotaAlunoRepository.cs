using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public interface INotaAlunoRepository
    {
        public void Inserir(NovaNotaAluno novaNotaAluno);
        public List<NotaAluno> ListaAlunosAprovados();
        public List<NotaAluno> ListaAlunosReprovados();
    }
}

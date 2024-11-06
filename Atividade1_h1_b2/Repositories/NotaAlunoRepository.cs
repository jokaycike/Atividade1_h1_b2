using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public class NotaAlunoRepository : INotaAlunoRepository
    {
        private static List<NotaAluno> dadosNotaAlunoList = new List<NotaAluno>();

        public NotaAlunoRepository() { }

        public void Inserir(NovaNotaAluno novaNotaAluno)
        {
            dadosNotaAlunoList.Add(new NotaAluno()
            {
                RaAluno = novaNotaAluno.RaAluno,
                idDicipina = novaNotaAluno.idDicipina,
                Nota = novaNotaAluno.Nota,
                Fequencia = novaNotaAluno.Fequencia
            });
        }

        public List<NotaAluno> ListaAlunosAprovados()
        {
            return dadosNotaAlunoList
                .Where(n => n.Nota >= 7.0 && n.Fequencia >= 75)
                .ToList();
        }

        public List<NotaAluno> ListaAlunosReprovados()
        {
            return dadosNotaAlunoList
                .Where(n => n.Nota < 7.0 || n.Fequencia < 75)
                .ToList();
        }
    }
}

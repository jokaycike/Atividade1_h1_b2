using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public class NotaAlunoRepository : INotaAlunoRepository
    {
        private static List<NotaAluno> dadosNotaAlunoList = new List<NotaAluno>();
        private static List<DadosAluno> dadosAlunoList = new List<DadosAluno>();
        private static List<Disciplina> dadosDisciplinasList = new List<Disciplina>();

        public void Inserir(NovaNotaAluno novaNotaAluno)
        {
            if (!AlunoExiste(novaNotaAluno.RaAluno))
            {
                throw new Exception("O aluno não existe");
            }

            if (!DisciplinaExiste(novaNotaAluno.idDicipina))
            {
                throw new Exception("O disciplina não existe");
            }

            if (NotaJaExiste(novaNotaAluno.RaAluno, novaNotaAluno.idDicipina))
            {
                throw new Exception("O nota ja inserida na disciplina");
            }

            dadosNotaAlunoList.Add(new NotaAluno()
            {
                RaAluno = novaNotaAluno.RaAluno,
                idDicipina = novaNotaAluno.idDicipina,
                Nota = novaNotaAluno.Nota,
                Fequencia = novaNotaAluno.Fequencia
            });
        }

        private bool NotaExiste(string raAluno, int idDisciplina)
        {
            throw new NotImplementedException();
        }

        private bool AlunoExiste(string raAluno)
        {
            throw new NotImplementedException();
        }

        public bool AlunoExiste(int raAluno)
        {
            return dadosAlunoList.Any(a => a.ra == raAluno);
        }

        public bool DisciplinaExiste(int idDisciplina)
        {
            return dadosDisciplinasList.Any(d => d.IdDisciplina == idDisciplina);
        }

        public bool NotaJaExiste(int raAluno, int idDisciplina)
        {
            return dadosNotaAlunoList.Any(n => n.RaAluno == raAluno && n.idDicipina == idDisciplina);
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

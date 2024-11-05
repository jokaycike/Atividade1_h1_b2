using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private static List<Disciplina> dadosDiciplinaList = new List<Disciplina>();

        public DisciplinaRepository() { }

        public void Inserir(NovaDisciplina novaDisciplina)
        {
            dadosDiciplinaList.Add(new Disciplina()
            {
                IdDisciplina = novaDisciplina.IdDisciplina,
                Nome = novaDisciplina.Nome,
                Curso = novaDisciplina.Curso,
            });
        }

        public List<Disciplina> obterTodasDisciplinas()
        {
            return dadosDiciplinaList;
        }
    }
}

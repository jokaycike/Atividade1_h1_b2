using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> obterTodasDisciplinas();

        public void Inserir(NovaDisciplina novaDisciplina);

    }
}

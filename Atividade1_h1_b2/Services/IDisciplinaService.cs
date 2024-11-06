using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Services
{
    public interface IDisciplinaService
    {
        public List<Disciplina> obterTodasDisciplinas();
        public Disciplina obterDisciplinaPorNome(string Nome);

        public bool Inserir(NovaDisciplina novaDisciplina);
    }
}

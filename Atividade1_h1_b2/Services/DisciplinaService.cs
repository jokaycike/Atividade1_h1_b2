using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Repositories;

namespace Atividade1_h1_b2.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository _diciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _diciplinaRepository = disciplinaRepository;
        }

        public bool Inserir(NovaDisciplina novaDisciplina)
        {
            Disciplina nomeDisciplina = _diciplinaRepository
                .obterDisciplinaPorNome(novaDisciplina.Nome);

            if (nomeDisciplina is not null) return false;
            _diciplinaRepository.Inserir(novaDisciplina);
            return true;
        }

        public Disciplina obterDisciplinaPorNome(string Nome)
        {
            return _diciplinaRepository.obterDisciplinaPorNome(Nome);
        }

        public List<Disciplina> obterTodasDisciplinas()
        {
            return _diciplinaRepository.obterTodasDisciplinas();
        }
    }
}

using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Repositories;

namespace Atividade1_h1_b2.Services
{
    public class NotaAlunoService : INotaAlunoService
    {
        private readonly INotaAlunoRepository _notaAlunoRepository;

        public NotaAlunoService(INotaAlunoRepository notaAlunoRepository)
        {
            _notaAlunoRepository = notaAlunoRepository;
        }

        public void Inserir(NovaNotaAluno novaNotaAluno)
        {
            _notaAlunoRepository.Inserir(novaNotaAluno);
        }

        public List<NotaAluno> ListaAlunosAprovados()
        {
            return _notaAlunoRepository.ListaAlunosAprovados();
        }

        public List<NotaAluno> ListaAlunosReprovados()
        {
            return _notaAlunoRepository.ListaAlunosReprovados();
        }
    }
}

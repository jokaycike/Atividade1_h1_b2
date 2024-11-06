using Atividade1_h1_b2.Models;
using Atividade1_h1_b2.Repositories;

namespace Atividade1_h1_b2.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public bool Inserir(NovoAluno novoAluno)
        {
            DadosAluno dadosAlunoCpf = _alunoRepository
                 .obterAlunosPorCpf(novoAluno.cpf);

            if (dadosAlunoCpf is not null) return false;


            DadosAluno dadosAlunoRa = _alunoRepository
                 .obterAlunosPorRa(novoAluno.RA);

            //outras de negocio, exemplo curso existir
            if (dadosAlunoRa is not null) return false;

            _alunoRepository.Inserir(novoAluno);

            return true;
        }

        public DadosAluno obterAlunosPorRa(int RA)
        {
            return _alunoRepository.obterAlunosPorRa(RA);
        }
        public DadosAluno obterAlunosPorCpf(string cpf)
        {
            return _alunoRepository.obterAlunosPorCpf(cpf);
        }

        public List<DadosAluno> obterTodosAlunos()
        {
            return _alunoRepository.obterTodosAlunos();
        }
    }
}

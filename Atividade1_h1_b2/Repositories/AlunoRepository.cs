using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private static List<DadosAluno> dadosAlunosList = new List<DadosAluno>();

        public AlunoRepository() { }

        public void Inserir(NovoAluno novoAluno)
        {
            dadosAlunosList.Add(new DadosAluno()
            {
                cpf = novoAluno.cpf,
                email = novoAluno.email,
                nome = novoAluno.nome,
                telefone = novoAluno.telefone,
                ra = novoAluno.RA
            });
        }

        public DadosAluno obterAlunosPorCpf(string cpf)
        {
            return dadosAlunosList.Where(a => a.cpf == cpf).FirstOrDefault();
        }

        public DadosAluno obterAlunosPorRa(int ra)
        {
            return dadosAlunosList.Where(a => a.ra == ra).FirstOrDefault();
        }

        public List<DadosAluno> obterTodosAlunos()
        {
            return dadosAlunosList;
        }
    }
}

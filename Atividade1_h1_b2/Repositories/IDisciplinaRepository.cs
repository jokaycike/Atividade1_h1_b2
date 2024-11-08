﻿using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Repositories
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> obterTodasDisciplinas();

        public Disciplina obterDisciplinaPorNome(string Nome);

        public void Inserir(NovaDisciplina novaDisciplina);

    }
}

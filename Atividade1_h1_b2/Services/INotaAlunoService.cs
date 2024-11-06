﻿using Atividade1_h1_b2.Models;

namespace Atividade1_h1_b2.Services
{
    public interface INotaAlunoService
    {
        public void Inserir(NovaNotaAluno novaNotaAluno);
        List<NotaAluno> ListaAlunosAprovados();
        List<NotaAluno> ListaAlunosReprovados();

    }
}

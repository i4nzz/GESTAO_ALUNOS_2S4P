﻿using GestaoAlunos.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Interfaces
{
    public interface IAlunoRepository : IRepositoryBase<Aluno>
    {
        public Aluno getAlunoByCPF(string cpf);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Entidades
{

    public class Aluno : EntidadeBase
    {
        protected Aluno()
        {
                
        }
        public string nome { get; private set; }
        public string email { get; private set; }
        public string telefone { get; private set; }
        public string cpf { get; private set; }

        public Aluno(string nome, string email, string telefone, string cpf)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.cpf = cpf;
        }
    }
}

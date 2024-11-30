using GestaoAlunos.Data.Context;
using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {

        private readonly AppDBContext _appDBContext;

        public AlunoRepository(AppDBContext appContext)
        {
            _appDBContext = appContext;
        }

        public void Adcionar(Aluno entidade)
        {
            // Insert
            _appDBContext.Aluno.Add(entidade);
            _appDBContext.SaveChanges();
        }

        public Aluno? getAlunoByCPF(string CPF)
        {
            // select * from Aluno Where cpf = CPF
            return _appDBContext.Aluno.Where(a => a.cpf == CPF).FirstOrDefault();
        }

        public Aluno? getByID(int id)
        {
            return _appDBContext.Aluno.Where(a => a.id == id).FirstOrDefault();
        }

        public IList<Aluno> getTodos()
        {
            // select * from Aluno
            return _appDBContext.Aluno.ToList();
        }

       
    }
}

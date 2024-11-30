using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using GestaoAlunos.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Services.Services
{
    public class AlunoServices : IAlunoService
    {

        private readonly IAlunoRepository _alunoRepository;

        public AlunoServices(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public bool Adcionar(Aluno aluno)
        {
            Aluno statusAlunoAdicionado = _alunoRepository.getAlunoByCPF(aluno.cpf);
            if (statusAlunoAdicionado is null)
            {
                _alunoRepository.Adcionar(aluno);
                return true;
            }
            return false;
        }
        

        public Aluno getByID(int id)
        {
            return _alunoRepository.getByID(id);
        }

        public IList<Aluno> getTodos()
        {
            return _alunoRepository.getTodos();
        }
    }
}

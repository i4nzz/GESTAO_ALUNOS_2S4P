using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Interfaces
{
    public interface IRepositoryBase<T> // Qualquer coisa
    {
        public void Adcionar(T entidade);
        public T getByID(int id);
        public IList<T> getTodos();
    }
}

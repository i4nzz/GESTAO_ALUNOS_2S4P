using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoAlunos.Domain.Entidades;

namespace GestaoAlunos.Data.Context
{
    public class AppDBContext : DbContext // Classe base do EF para comunicar com o banco de dados               
    {
        
        public DbSet<Aluno> Aluno { get; set; }
        // DbSet<Aluno> representa a tabela Aluno no banco de dados.
        // Propiedade que interage diretamente com o banco. Por meio dela que conseguiremos usar o insert, update...
        // Intermedio entre o banco e a aplicação
        
         // Recebe configurações (como o tipo de banco de dados e string de conexão) através do DbContextOptions.
         // Passa essas configurações para a classe base (DbContext) para configurar automaticamente a conexão com o banco 
         // Sem ele, precisariamos configurar a conexao manualmente
        public AppDBContext (DbContextOptions<AppDBContext> options) : base(options) 
        {
            
        }
    }
}

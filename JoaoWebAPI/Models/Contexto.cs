using Microsoft.EntityFrameworkCore;

namespace JoaoWebAPI
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
          : base(options)
        {
          
        }
        public DbSet<InformacaoNavegacao> InformacaoNavegacao { get; set; }
    }
}

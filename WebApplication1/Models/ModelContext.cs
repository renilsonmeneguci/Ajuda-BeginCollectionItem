using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ModelContext : System.Data.Entity.DbContext
    {
        public ModelContext() : base("DefaultContext")
        {
            
        }

        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
    }
}
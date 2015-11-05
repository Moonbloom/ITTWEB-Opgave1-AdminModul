using System.Data.Entity;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul
{
    public class EsDbContext : DbContext
    {
        public EsDbContext() : base("name=EsDbContext")
        {}

        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComponentType> ComponentTypes { get; set; }
        public virtual DbSet<LoanInformation> LoanInformations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
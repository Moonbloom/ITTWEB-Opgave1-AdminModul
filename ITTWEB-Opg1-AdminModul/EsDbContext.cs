using System.Data.Entity;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul
{
    public class EsDbContext : DbContext
    {
        public EsDbContext() : base("name=EsDbContext")
        {
            Database.SetInitializer(new EsDbInitializer());
        }

        public class EsDbInitializer : DropCreateDatabaseAlways<EsDbContext> //DropCreateDatabaseAlways<OdenseTimeRegApiContext>
        {
            protected override void Seed(EsDbContext context)
            {
                new DbUpdater().Update(context);

                base.Seed(context);
            }
        }

        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<ComponentType> ComponentTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<LoanInformation> LoanInformations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
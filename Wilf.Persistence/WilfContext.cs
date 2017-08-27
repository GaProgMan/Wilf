using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Wilf.Entities;

namespace Wilf.Persistence
{
    public class WilfContext : DbContext, IWilfContext
    {
        public WilfContext(DbContextOptions<WilfContext> options) : base(options) { }

        public WilfContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Wilf");

            modelBuilder.AddPrimaryKeys();
            
            modelBuilder.AddForeignKeys();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.ApplyAuditInformation();
            
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public DbSet<Season> Seasons { get; set; }
        public DbSet<Episode> Episodes { get; set; }
    }
}
using System.Threading;
using System.Threading.Tasks;
using DomainEntity.Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.DataModel
{
    public sealed class DatabaseContext : DbContext
    {

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        public DbSet<TypeTour> TypeTours { get; set; }
        public DbSet<TypeTransport> TypeTransports { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<StepTour> StepTours { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.ApplyAuditInformation();

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}

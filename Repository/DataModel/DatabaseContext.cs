using System.Threading;
using System.Threading.Tasks;
using DomainEntity.Entity;
using DomainEntity.Entity.Tour;
using DomainEntity.Entity.User;
using Microsoft.EntityFrameworkCore;

namespace Repository.DataModel
{
    public sealed class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

        public DbSet<DatesPrices> DatesPrices { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourDescription> TourDescriptions { get; set; }
        public DbSet<TourImages> TourImages { get; set; }
        public DbSet<TourItinerary> TourItineraries { get; set; }


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
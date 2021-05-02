using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class AccountTrackingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Connection String");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CurrencyUnit> CurrencyUnits { get; set; }
        public DbSet<CorporateCurrentCard> CorporateCurrentCards { get; set; }
    }
}

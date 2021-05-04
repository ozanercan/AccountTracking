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
            optionsBuilder.UseMySQL("Server=localhost; Database=AccountTracking; Port=63047; Uid=root; Pwd=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region User and Authorization
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

        #region Current Cards
        public DbSet<CurrentCard> CurrentCards { get; set; }
        public DbSet<CorporateCurrentCard> CorporateCurrentCards { get; set; }
        public DbSet<IndividualCurrentCard> IndividualCurrentCards { get; set; }
        public DbSet<ForeignIndividualCurrentCard> ForeignIndividualCurrentCards { get; set; }
        public DbSet<LocalIndividualCurrentCard> LocalIndividualCurrentCards { get; set; }
        #endregion

        #region Installment
        public DbSet<InstallmentEntry> InstallmentEntries { get; set; }
        public DbSet<InstallmentOut> InstallmentOuts { get; set; }
        public DbSet<InstallmentStatu> InstallmentStatus { get; set; }
        #endregion

        #region Money Transfer
        public DbSet<MoneyTransferEntry> MoneyTransferEntries { get; set; }
        public DbSet<MoneyTransferOut> MoneyTransferOuts { get; set; }
        public DbSet<PaymentStatu> PaymentStatus { get; set; }
        #endregion

        #region Other
        public DbSet<CurrencyUnit> CurrencyUnits { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        #endregion
    }
}

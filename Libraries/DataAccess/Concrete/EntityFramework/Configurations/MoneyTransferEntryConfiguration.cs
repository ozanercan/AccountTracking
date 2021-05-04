using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class MoneyTransferEntryConfiguration : IEntityTypeConfiguration<MoneyTransferEntry>
    {
        public void Configure(EntityTypeBuilder<MoneyTransferEntry> builder)
        {
            builder.ToTable("MoneyTransferEntries");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentId).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.PaymentStatuId).IsRequired();
            builder.Property(p => p.CurrencyUnitId).IsRequired();
            builder.Property(p => p.SecondaryIdentity).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.EstimatedReceivingMoneyDateTime).IsRequired();
            builder.Property(p => p.ReceivingMoneyDateTime).IsRequired(false);
            builder.Property(p => p.RegisterDateTime).IsRequired();
        }
    }
}

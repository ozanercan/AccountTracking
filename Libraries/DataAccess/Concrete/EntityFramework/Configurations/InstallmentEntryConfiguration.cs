using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class InstallmentEntryConfiguration : IEntityTypeConfiguration<InstallmentEntry>
    {
        public void Configure(EntityTypeBuilder<InstallmentEntry> builder)
        {
            builder.ToTable("InstallmentEntries");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.InstallmentStatuId).IsRequired();
            builder.Property(p => p.MoneyTransferEntryId).IsRequired();
            builder.Property(p => p.SecondaryIdentity).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Which).IsRequired();
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.EstimatedPaymentDateTime).IsRequired();
            builder.Property(p => p.PaymentDateTime).IsRequired(false);
            builder.Property(p => p.RegisterDateTime).IsRequired();
        }
    }
}

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class InstallmentOutConfiguration : IEntityTypeConfiguration<InstallmentOut>
    {
        public void Configure(EntityTypeBuilder<InstallmentOut> builder)
        {
            builder.ToTable("InstallmentOuts");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.InstallmentStatuId).IsRequired();
            builder.Property(p => p.MoneyTransferOutId).IsRequired();
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

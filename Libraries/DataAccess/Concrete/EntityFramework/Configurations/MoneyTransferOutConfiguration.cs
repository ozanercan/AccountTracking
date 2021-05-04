using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class MoneyTransferOutConfiguration : IEntityTypeConfiguration<MoneyTransferOut>
    {
        public void Configure(EntityTypeBuilder<MoneyTransferOut> builder)
        {
            builder.ToTable("MoneyTransferOuts");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentId).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.CurrencyUnitId).IsRequired();
            builder.Property(p => p.SecondaryIdentity).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(10,2)");
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.EstimatedPaymentDateTime).IsRequired();
            builder.Property(p => p.PaymentDateTime).IsRequired(false);
            builder.Property(p => p.RegisterDateTime).IsRequired();
        }
    }
}

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class PaymentStatuConfiguration : IEntityTypeConfiguration<PaymentStatu>
    {
        public void Configure(EntityTypeBuilder<PaymentStatu> builder)
        {
            builder.ToTable("PaymentStatus");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        }
    }
}

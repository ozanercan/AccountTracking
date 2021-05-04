using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class CorporateCurrentCardConfiguration : IEntityTypeConfiguration<CorporateCurrentCard>
    {
        public void Configure(EntityTypeBuilder<CorporateCurrentCard> builder)
        {
            builder.ToTable("CorporateCurrentCards");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentCardId).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.TaxNumber).IsRequired().HasMaxLength(20);
            builder.Property(p => p.TaxAdministration).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
        }
    }
}

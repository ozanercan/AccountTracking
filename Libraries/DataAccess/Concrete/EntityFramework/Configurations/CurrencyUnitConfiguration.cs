using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class CurrencyUnitConfiguration : IEntityTypeConfiguration<CurrencyUnit>
    {
        public void Configure(EntityTypeBuilder<CurrencyUnit> builder)
        {
            builder.ToTable("CurrencyUnits");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.ShortName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Symbol).IsRequired().HasMaxLength(3);
            builder.Property(p => p.IsActive).IsRequired();
        }
    }
}

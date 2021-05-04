using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentCardId).IsRequired();
            builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Value).IsRequired().HasMaxLength(1000);
        }
    }
}

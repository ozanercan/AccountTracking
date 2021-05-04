using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class CurrentCardConfiguration : IEntityTypeConfiguration<CurrentCard>
    {
        public void Configure(EntityTypeBuilder<CurrentCard> builder)
        {
            builder.ToTable("CurrentCards");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.RegisteredDateTime).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
        }
    }
}

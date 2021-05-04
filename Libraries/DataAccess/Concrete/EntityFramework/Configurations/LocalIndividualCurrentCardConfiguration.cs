using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class LocalIndividualCurrentCardConfiguration : IEntityTypeConfiguration<LocalIndividualCurrentCard>
    {
        public void Configure(EntityTypeBuilder<LocalIndividualCurrentCard> builder)
        {
            builder.ToTable("LocalIndividualCurrentCards");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.IndividualCurrentCardId).IsRequired();
            builder.Property(p => p.IdentityNumber).IsRequired().HasMaxLength(15);
        }
    }
}

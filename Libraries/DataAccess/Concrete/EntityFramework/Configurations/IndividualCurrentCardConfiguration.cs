using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class IndividualCurrentCardConfiguration : IEntityTypeConfiguration<IndividualCurrentCard>
    {
        public void Configure(EntityTypeBuilder<IndividualCurrentCard> builder)
        {
            builder.ToTable("IndividualCurrentCards");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentCardId).IsRequired();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.BirthDate).IsRequired();
        }
    }
}

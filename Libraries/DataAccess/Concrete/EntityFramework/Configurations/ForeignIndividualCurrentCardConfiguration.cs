using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class ForeignIndividualCurrentCardConfiguration : IEntityTypeConfiguration<ForeignIndividualCurrentCard>
    {
        public void Configure(EntityTypeBuilder<ForeignIndividualCurrentCard> builder)
        {
            builder.ToTable("ForeignIndividualCurrentCards");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.IndividualCurrentCardId).IsRequired();
            builder.Property(p => p.NationalityId).IsRequired();
            builder.Property(p => p.PassportIdentityNumber).IsRequired().HasMaxLength(50);
        }
    }
}

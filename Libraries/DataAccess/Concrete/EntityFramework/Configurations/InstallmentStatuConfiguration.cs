using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class InstallmentStatuConfiguration : IEntityTypeConfiguration<InstallmentStatu>
    {
        public void Configure(EntityTypeBuilder<InstallmentStatu> builder)
        {
            builder.ToTable("InstallmentStatus");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        }
    }
}

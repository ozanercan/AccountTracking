using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Emails");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CurrentCardId).IsRequired();
            builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Value).IsRequired().HasMaxLength(1000);
        }
    }
}

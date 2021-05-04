using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class BlackListConfiguration : IEntityTypeConfiguration<BlackList>
    {
        public void Configure(EntityTypeBuilder<BlackList> builder)
        {
            builder.ToTable("BlackLists");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.CurrentCardId).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.RegisterDateTime).IsRequired();
        }
    }
}

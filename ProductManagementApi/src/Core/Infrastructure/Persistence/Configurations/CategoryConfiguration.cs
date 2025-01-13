using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryID);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .HasMaxLength(500);

            builder.Property(c => c.CreatedBy)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.UpdatedBy)
                .HasMaxLength(100);

            // Filtro global para IsDeleted
            builder.HasQueryFilter(c => !c.IsDeleted);
        }
    }
} 
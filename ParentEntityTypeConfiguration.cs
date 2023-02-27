using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorWasmEfCoreDenormalized;

public class ParentEntityTypeConfiguration : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.HasMany(parent => parent.Children)
            .WithOne(child => child.Parent);
    }    
}
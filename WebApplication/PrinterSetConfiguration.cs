using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication;

public class PrinterSetConfiguration
	: IEntityTypeConfiguration<PrinterEntity>
{
	public void Configure(EntityTypeBuilder<PrinterEntity> builder)
	{
        // should I hide base type? or it does not matter? (https://docs.microsoft.com/en-us/ef/core/modeling/inheritance)
        builder
            .Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasKey(e => e.Id);

        builder
            .HasIndex(e => e.Token)
            .IsUnique();

        builder
            .Property(e => e.Token)
            .ValueGeneratedOnAdd();
    }
}

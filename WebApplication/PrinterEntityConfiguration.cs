using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.InMemory.ValueGeneration.Internal;

namespace WebApplication;

internal sealed class PrinterEntityConfiguration
	: IEntityTypeConfiguration<PrinterEntity>
{
	public void Configure(EntityTypeBuilder<PrinterEntity> builder)
	{
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
			.HasValueGenerator<>()
			.ValueGeneratedOnAdd();
	}
}

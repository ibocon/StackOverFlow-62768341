using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebApplication;

internal sealed class PrinterEntityConfiguration
	: IEntityTypeConfiguration<PrinterEntity>
{
	private readonly DatabaseFacade _database;

	public PrinterEntityConfiguration(DatabaseFacade database)
	{
		_database = database;
	}

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

		var tokenBuilder = builder
			.Property(e => e.Token)
			.ValueGeneratedOnAdd();

		if (_database.IsInMemory())
		{
			tokenBuilder.HasValueGenerator<InMemoryGuidValueGenerator>();
		}
	}
}

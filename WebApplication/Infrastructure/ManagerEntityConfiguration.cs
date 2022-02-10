using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication;

internal sealed class ManagerEntityConfiguration
	: IEntityTypeConfiguration<ManagerEntity>
{
	private readonly DatabaseFacade _database;

	public ManagerEntityConfiguration(DatabaseFacade database)
	{
		_database = database;
	}

	public void Configure(EntityTypeBuilder<ManagerEntity> builder)
	{
		builder
			.Property(e => e.Id)
			.ValueGeneratedOnAdd();

		builder
			.HasKey(e => e.Id);

		builder
			.HasIndex(e => e.Identifier)
			.IsUnique();

		var identifierBuilder = builder
			.Property(e => e.Identifier)
			.ValueGeneratedOnAdd();

		if (_database.IsInMemory())
		{
			identifierBuilder.HasValueGenerator<InMemoryGuidValueGenerator>();
		}

		builder
			.Property(e => e.Email);
	}
}

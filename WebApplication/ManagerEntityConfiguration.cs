using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication;

internal sealed class ManagerEntityConfiguration
	: IEntityTypeConfiguration<ManagerEntity>
{
	public void Configure(EntityTypeBuilder<ManagerEntity> builder)
	{
		builder
			.Property(e => e.Id)
			.ValueGeneratedOnAdd();

		builder
			.HasKey(e => e.Id);

		builder
			.Property(e => e.Email);
	}
}

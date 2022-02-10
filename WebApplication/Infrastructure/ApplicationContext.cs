using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebApplication;

public class ApplicationContext
	: DbContext
{
	public ApplicationContext(DbContextOptions<ApplicationContext> options)
		: base(options)
	{
	}

	public DbSet<ManagerEntity> ManagerSet { get; set; }
	public DbSet<PrinterEntity> PrinterSet { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfiguration(new ManagerEntityConfiguration(Database));
		modelBuilder.ApplyConfiguration(new PrinterEntityConfiguration(Database));
	}
}

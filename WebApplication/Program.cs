using Microsoft.EntityFrameworkCore;
using WebApplication;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("WebApplication"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapGet("/printer", async (ApplicationContext context) =>
{
	IList<PrinterEntity> printers = await context.PrinterSet.ToListAsync();
	return printers;
});

app.MapPost("/printer", async (ApplicationContext context) =>
{
	PrinterEntity printer = new()
	{
		Manager = new ManagerEntity("master@google.com"),
	};

	await context.PrinterSet.AddAsync(printer);
	await context.SaveChangesAsync();

	return printer;
});

app.Run();

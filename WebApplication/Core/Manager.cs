namespace WebApplication;

public class Manager
{
	public Manager(Guid identifier, string email)
	{
		Identifier = identifier;
		Email = email;
	}

	public Guid Identifier { get; }
	public string Email { get; }

	public void FixPrinter(Printer printer)
	{
		printer.IsOutOfControl = true;
	}
}

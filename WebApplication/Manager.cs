namespace WebApplication;

public class Manager
{
	public Manager(string email)
	{
		Email = email;
	}

	public string Email { get; }

	public void FixPrinter(Printer printer)
	{
		throw new NotImplementedException();
	}
}

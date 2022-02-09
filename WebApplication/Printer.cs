namespace WebApplication;

public class Printer
{
	public Printer(Guid token)
	{
		Token = token;
	}

	protected Printer()
	{
	}

	public Guid Token { get; }

	public Manager? Manager { get; }
}

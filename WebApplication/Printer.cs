namespace WebApplication;

public class Printer
{
	public Printer(Guid token)
	{
		Token = token;
	}

	public Guid Token { get; }
}

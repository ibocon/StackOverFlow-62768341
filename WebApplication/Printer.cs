namespace WebApplication;

public class Printer
{
	public Printer(Guid token)
	{
		Token = token;
		Manager = null;
	}

	public Guid Token { get; }

	public Manager? Manager { get; set; }
}

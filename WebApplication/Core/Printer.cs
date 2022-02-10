namespace WebApplication;

public class Printer
{
	public Printer(Guid token)
	{
		Token = token;
		Manager = null;
		IsOutOfControl = false;
	}

	public Guid Token { get; }

	public Manager? Manager { get; set; }

	public bool IsOutOfControl { get; set; }
}

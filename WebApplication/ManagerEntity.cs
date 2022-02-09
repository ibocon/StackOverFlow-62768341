namespace WebApplication;

public sealed class ManagerEntity
	: Manager
{
	public ManagerEntity(string email)
		: base(email)
	{
	}

	public long Id { get; }
}

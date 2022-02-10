namespace WebApplication;

public sealed class ManagerEntity
	: Manager
{
	public ManagerEntity(string email)
		: base(Guid.Empty, email)
	{
	}

	public long Id { get; }
}

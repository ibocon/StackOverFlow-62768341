namespace WebApplication;

public sealed class PrinterEntity
	: Printer
{
	public PrinterEntity()
		: base(Guid.Empty)
	{
	}

	public long Id { get; }
}

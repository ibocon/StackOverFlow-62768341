namespace WebApplication;

public class PrinterEntity
	: Printer
{
    public PrinterEntity(long id, Guid token)
        : base(token)
    {
        Id = id;
    }

    // should I define parameterless constructor for EntityFramework Core?
    public PrinterEntity()
        : base(Guid.Empty)
    {
        Id = 0;
    }

    public long Id { get; }
}

namespace MeterReadManager.Data.Repository;

public class BaseRepository
{
    protected readonly MeterReadManagerContext _context;

    public BaseRepository(MeterReadManagerContext context)
    {
        _context = context;
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

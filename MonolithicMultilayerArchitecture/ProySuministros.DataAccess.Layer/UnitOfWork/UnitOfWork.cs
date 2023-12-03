
namespace ProySuministros.DataAccess.Layer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProySuministrosDbContext _context;
        public UnitOfWork(ProySuministrosDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

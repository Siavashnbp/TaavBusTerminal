using BusTerminal.EnitityMap;

namespace BusTerminal
{
    public class DbRepository
    {
        private static DbRepository? _dbRepositoryInstance;
        private BusTerminalDbContext _dbContex;
        private DbRepository()
        {
        }
        public static DbRepository GetInstance() => _dbRepositoryInstance ??= new DbRepository();
        public void Add<T>(T entity)
        {
            _dbContex = new BusTerminalDbContext();
            if (entity is not null)
            {
                _dbContex.Add(entity);
                var changes = _dbContex.SaveChanges();
                if (changes < 1)
                {
                    throw new Exception("Changes were nos saved");
                }
                _dbContex.Dispose();
                return;
            }
            throw new Exception("Item cannot be null");
        }
    }
}

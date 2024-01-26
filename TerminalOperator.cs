using BusTerminal.Db;
using BusTerminal.Entities;
namespace BusTerminal
{
    public static class TerminalOperator
    {
        private static readonly DbRepository<Bus> _busRepository;
        static TerminalOperator()
        {
            _busRepository = DbRepository<Bus>.GetInstance();
        }
        public static void AddBus(string name, BusType busType)
        {
            var bus = new Bus(name, busType);
            _busRepository.Add(bus);
        }
        public static List<Bus> GetBusses()
        {
            return _busRepository.GetAll();
        }
    }
}

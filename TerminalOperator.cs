using BusTerminal.Entities;

namespace BusTerminal
{
    public static class TerminalOperator
    {
        private static readonly DbRepository _dbRepository;
        static TerminalOperator()
        {
            _dbRepository = DbRepository.GetInstance();
        }
        public static void AddBus(string name, BusType busType)
        {
            var bus = new Bus(name, busType);
            _dbRepository.Add(bus);
        }
        //public static List<Bus> GetBusses()
        //{

        //}
    }
}

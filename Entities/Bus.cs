namespace BusTerminal.Entities
{
    public abstract class Bus
    {
        public Bus(string name, BusType busType)
        {
            Name = name;
            BusType = busType;
            SeatCount = busType == BusType.VIP ? 30 : 44;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public BusType BusType { get; set; }
    }
    public enum BusType
    {
        Normal,
        VIP
    }
}

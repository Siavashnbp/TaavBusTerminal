namespace BusTerminal.Entities
{
    public class Bus
    {
        public Bus()
        {

        }
        public Bus(string name, BusType busType)
        {
            Name = name;
            BusType = busType;
            var seatCount = busType == BusType.VIP ? 30 : 44;
            BusSeats = new List<BusSeat>();
            for (int id = 1; id <= seatCount; id++)
            {
                BusSeats.Add(new BusSeat(id, this));
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BusSeat> BusSeats { get; set; }
        public BusType BusType { get; set; }
        public List<Trip>? Trips { get; set; }
    }
    public enum BusType
    {
        Normal,
        VIP
    }
}

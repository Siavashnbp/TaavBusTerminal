﻿namespace BusTerminal.Entities
{
    public class Location
    {
        public Location(string province, string city, string name)
        {
            Province = province;
            City = city;
            Name = name;
        }
        public int Id { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public List<Trip> TripsAsOrigin { get; set; }
        public List<Trip> TripsAsDestination { get; set; }
    }
}

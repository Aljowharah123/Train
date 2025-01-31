using System.Net.Sockets;

namespace Train.Models
{
    public class Trains
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}

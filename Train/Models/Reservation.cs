namespace Train.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string PassengerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

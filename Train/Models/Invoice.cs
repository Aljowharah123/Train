namespace Train.Models
{
    public class Invoice
    {
        public int Id { get; set; } 
        public string TicketId { get; set; }
        public string FromDirect { get; set; }

        public string Todirect { get; set; }

        public string PassengerName { get; set; }

        public string PassengerEmail { get; set; }
        public string PassengerPhone { get; set; }
        public string PassegerDate { get; set; }

        public int passengerCounts { get; set; }
        public decimal Price { get;set; }




    }
}

namespace Train.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public string PassengerName { get; set; }
        public string Location1 { get; set; }
        public string Location2 { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Price { get; set; }
    }
}

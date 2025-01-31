using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Train.Data;
using Train.Models;

namespace Train.Controllers
{
   

    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Station()
        {
            var Station= _context.Stations.ToList(); 
            return View(Station);  
        }

        public IActionResult Reservation(int id)
        {
            var tickes= _context.Tickets.FirstOrDefault(b=>b.Id==id);
            return View(tickes);  
        }

        public IActionResult Invoice(Invoice invoice)
        {
            var rand = new Random();
            var uid = rand.Next(100000, 1000000);
            var inv = new Invoice()
            {
                 Id = uid,
                 FromDirect=invoice.FromDirect,
                 PassegerDate=invoice.PassegerDate,
                 passengerCounts=invoice.passengerCounts,
                 PassengerEmail=invoice.PassengerEmail, 
                 PassengerName=invoice.PassengerName,  
                 Price=invoice.Price,  
                 TicketId=invoice.TicketId,
                 Todirect=invoice.Todirect,    
            };


           return View(inv);
        }
        public IActionResult Ticket()
        {
            var tickets = _context.Tickets.ToList();
            return View(tickets);
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

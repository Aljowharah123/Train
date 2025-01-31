using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Train.Data;
using Train.Models;

namespace Train.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DashboardController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNewStation(Station station)
        {

            _context.Stations.Add(station);
            _context.SaveChanges(); 
            var _stations= _context.Stations.ToList();
            return View("station", _stations);

        }

        public IActionResult UpdateStations(int id)
        {
          
           var _stations= _context.Stations.Where(b=>b.Id==id);
            Console.WriteLine(_stations);
            return View("updatestations",_stations);
        }
        public IActionResult UpdateStation(Station station)
        {

            _context.Stations.Update(station);
            _context.SaveChanges();
            var _stations = _context.Stations.ToList();
            return PartialView("station", _stations);

        }

        public IActionResult Tickets()
        {
            var Ticket=_context.Tickets.ToList();
            var Station = _context.Stations.ToList();
            TempData["station"] = Station;
            return PartialView("tickets/index", Ticket);
        }

        public IActionResult CreateNewTickets(Ticket ticket)
        {
            _context.Tickets.Add(ticket);       
            _context.SaveChanges();
            var tickets= _context.Tickets.ToList();
            var Station = _context.Stations.ToList();
            TempData["station"] = Station;
            return PartialView("tickets/index", tickets);
        }

        public IActionResult DeleteTicket(int id)
        {
            var searchti = _context.Tickets.SingleOrDefault(b=>b.Id== id);  
            if (searchti != null)
            {
                _context.Tickets.Remove(searchti);
                _context.SaveChanges();
            }
            var tickets = _context.Tickets.ToList();
            return PartialView("tickets/index", tickets);

        }
        public IActionResult DeleteStation(int id)
        {
            var search=_context.Stations.SingleOrDefault(b=>b.Id==id);
            if (search != null)
            {
                _context.Stations.Remove(search);
                _context.SaveChanges();
            }
            var _stations = _context.Stations.ToList();
            return PartialView("_Partiial/_StationPartial", _stations);

        }
        public IActionResult Station() {

            var station = _context.Stations.ToList();
            return View(station);
        
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Task_Dashboard.Models;
using System.Web.Http;
namespace Task_Dashboard.Controllers
{
    public class TicketController : Controller
    {
        private readonly HelpDeskV7Context db = new HelpDeskV7Context();

        private readonly ILogger<TicketController> _logger;

        public TicketController(ILogger<TicketController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

        
            List<WorkOrder> tickets = db.WorkOrders.ToList();
            List<Person> person = db.Persons.ToList();
            Guid a = Guid.NewGuid();

            for (int i = 0; i < person.Count; ++i)
            {
                if (person[i].PrimaryLogin == User.Identity.Name)
                    a = person[i].Id;
            }

            var Tickets = from t in db.WorkOrders
                           where t.CompletedDate == null
                           where t.AssigneeId == a
                           select t;

            ViewData["sr"] = from r in db.ServiceRequests
                     where r.CompletedDate == null
                     where r.AssigneeId == a
                     select r;

            ViewData["status"] = from s in db.Statuses
                                  select s;
            ViewData["person"] = from p in db.Persons
                                 select p;

            return View(Tickets);
        }


    }
}
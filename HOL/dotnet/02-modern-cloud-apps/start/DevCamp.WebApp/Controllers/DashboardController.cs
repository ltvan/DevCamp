using DevCamp.WebApp.Utils;
using IncidentAPI;
using IncidentAPI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevCamp.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //##### API DATA HERE #####
            //##### API DATA HERE #####
            List<Incident> incidents;
            using (var client = IncidentApiHelper.GetIncidentAPIClient())
            {
                var results = await client.Incident.GetAllIncidentsAsync();
                incidents = JsonConvert.DeserializeObject<List<Incident>>(results);
            }
            return View(incidents);
            //##### API DATA HERE #####
            //##### ADD CACHING HERE #####
            //##### ADD CACHING HERE #####
            //##### API DATA HERE #####

        }
    }
}
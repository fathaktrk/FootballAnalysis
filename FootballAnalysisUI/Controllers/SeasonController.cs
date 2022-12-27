using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FootballAnalysisUI.Controllers
{
    public class SeasonController : Controller
    {
        public IActionResult Index()
        {
            SeasonManager sm = new SeasonManager(new EfSeasonDal());
            return View(sm.ListAll().OrderByDescending(x=> x.SeasonYear).ToList());
        }
    }
}
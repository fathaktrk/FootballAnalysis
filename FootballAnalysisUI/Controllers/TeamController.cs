using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using HtmlAgiltyPack.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballAnalysisUI.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllTeamMatches(int ID)
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            HAPMatchScoreDal hAPMatchScoreDal = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == ID));
            return View(hAPMatchScoreDal.GetAllMatchScores(2017));
        }

        public IActionResult TeamList()
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            return View(teamInfos);
        }

        [HttpGet]
        public IActionResult TeamvsTeam()
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var item in teamInfos)
            {
                selectListItems.Add(new SelectListItem{ Text = item.RealTeamName, Value = item.ID.ToString()});
            }
            return View(selectListItems);
        }
        [HttpPost]
        public IActionResult AllTeamMatchesBetweenTwoTeam(string team1, string team2)
        {

            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            HAPMatchScoreDal hAPMatchScoreDal = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)));
             return View(hAPMatchScoreDal.GetAllMatchScores(2017).Where(x=> x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).RealTeamName).ToList());
        }

        public IActionResult DetailedTeamvsTeam(string team1, string team2)
        {
            return View();
        }
    }
}
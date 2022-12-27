using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FootballAnalysisUI.Models;
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
            return View(hAPMatchScoreDal.GetAllMatchScores());
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
                selectListItems.Add(new SelectListItem { Text = item.RealTeamName, Value = item.ID.ToString() });
            }
            return View(selectListItems);
        }
        [HttpPost]
        public IActionResult AllTeamMatchesBetweenTwoTeam(string team1, string team2)
        {

            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            HAPMatchScoreDal hAPMatchScoreDalTeamOne = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)));
            HAPMatchScoreDal hAPMatchScoreDalTeamTwo = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)));
            List<MatchScore> matchList = new List<MatchScore>();
            matchList.AddRange(hAPMatchScoreDalTeamOne.GetAllMatchScores().Where(x => x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).RealTeamName).ToList());
            matchList.AddRange(hAPMatchScoreDalTeamTwo.GetAllMatchScores().Where(x => x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)).RealTeamName).ToList());
            List<MatchScore> listedMatchList = matchList.OrderByDescending(MatchScore => Convert.ToDateTime(MatchScore.date)).ToList();

            return View(listedMatchList);
        }

        public IActionResult DetailedTeamvsTeam(string team1, string team2)
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var teamInfos = teamInfoManager.ListAll();
            Compare cmp = new Compare();
            cmp.TeamOneName = teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)).RealTeamName;
            cmp.TeamTwoName = teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).RealTeamName; ;
            cmp.TeamOneURLNumber = teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)).InUrlTeamNumber;
            cmp.TeamTwoURLNumber = teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).InUrlTeamNumber;
            HAPMatchScoreDal hAPMatchScoreDalTeamOne = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)));
            HAPMatchScoreDal hAPMatchScoreDalTeamTwo = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)));

            List<MatchScore> matchListTeamOne = hAPMatchScoreDalTeamOne.GetAllMatchScores().Where(x => x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).RealTeamName).ToList();
            List<MatchScore> matchListTeamTwo = hAPMatchScoreDalTeamTwo.GetAllMatchScores().Where(x => x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)).RealTeamName).ToList();

            foreach (var item in matchListTeamOne)
            {
                cmp.TeamOneGoalinHome += item.HomeScore;
                cmp.TeamTwoGoalinAway += item.OpponentScore;

                if (item.HomeScore == item.OpponentScore)
                {
                    cmp.TeamOneHomeDraw += 1;
                }
                else if (item.HomeScore > item.OpponentScore)
                {
                    cmp.TeamOneWininHome += 1;
                }
                else
                {
                    cmp.TeamTwoWininAway += 1;
                }
                cmp.MatchCount += 1;
            }

            foreach (var item in matchListTeamTwo)
            {
                cmp.TeamOneGoalinAway += item.OpponentScore;
                cmp.TeamTwoGoalinHome += item.HomeScore;

                if (item.HomeScore == item.OpponentScore)
                {
                    cmp.TeamTwoHomeDraw += 1;
                }
                else if (item.HomeScore > item.OpponentScore)
                {
                    cmp.TeamTwoWininHome += 1;
                }
                else
                {
                    cmp.TeamOneWininAway += 1;
                }
                cmp.MatchCount += 1;
            }
            cmp.DrawCount = cmp.TeamOneHomeDraw + cmp.TeamTwoHomeDraw;
            cmp.TeamOneGoalAll = cmp.TeamOneGoalinHome + cmp.TeamOneGoalinAway;
            cmp.TeamTwoGoalAll = cmp.TeamTwoGoalinHome + cmp.TeamTwoGoalinAway;
            cmp.GoalAll = cmp.TeamOneGoalAll + cmp.TeamTwoGoalAll;
            cmp.TeamOneWinAll = cmp.TeamOneWininHome + cmp.TeamOneWininAway;
            cmp.TeamTwoWinAll = cmp.TeamTwoWininHome + cmp.TeamTwoWininAway;

            return View(cmp);
        }
    }
}
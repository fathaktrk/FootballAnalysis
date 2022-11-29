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
            List<TeamInfo> teamInfos = new List<TeamInfo>();
            teamInfos.Add(new TeamInfo { ID = 0, InUrlTeamName = "galatasaray", RealTeamName = "Galatasaray", InUrlTeamNumber = 141 }); //0
            teamInfos.Add(new TeamInfo { ID = 1, InUrlTeamName = "fenerbahce", RealTeamName = "Fenerbahçe", InUrlTeamNumber = 36 }); //1 
            teamInfos.Add(new TeamInfo { ID = 2, InUrlTeamName = "trabzonspor", RealTeamName = "Trabzonspor", InUrlTeamNumber = 449 }); //2
            teamInfos.Add(new TeamInfo { ID = 3, InUrlTeamName = "besiktas-istanbul", RealTeamName = "Beşiktaş JK", InUrlTeamNumber = 114 }); //3
            teamInfos.Add(new TeamInfo { ID = 4, InUrlTeamName = "istanbul-basaksehir-fk", RealTeamName = "İstanbul Başakşehir FK", InUrlTeamNumber = 6890 }); //4
            teamInfos.Add(new TeamInfo { ID = 5, InUrlTeamName = "adana-demirspor", RealTeamName = "Adana Demirspor", InUrlTeamNumber = 3840 }); //5
            teamInfos.Add(new TeamInfo { ID = 6, InUrlTeamName = "konyaspor", RealTeamName = "Konyaspor", InUrlTeamNumber = 2293 }); //6
            teamInfos.Add(new TeamInfo { ID = 7, InUrlTeamName = "alanyaspor", RealTeamName = "Alanyaspor", InUrlTeamNumber = 11282 }); //7
            teamInfos.Add(new TeamInfo { ID = 8, InUrlTeamName = "antalyaspor", RealTeamName = "Antalyaspor", InUrlTeamNumber = 589 }); //8
            teamInfos.Add(new TeamInfo { ID = 9, InUrlTeamName = "mke-ankaragucu", RealTeamName = "MKE Ankaragücü", InUrlTeamNumber = 868 }); //9
            teamInfos.Add(new TeamInfo { ID = 10, InUrlTeamName = "sivasspor", RealTeamName = "Sivasspor", InUrlTeamNumber = 2381 }); //10
            teamInfos.Add(new TeamInfo { ID = 11, InUrlTeamName = "kayserispor", RealTeamName = "Kayserispor", InUrlTeamNumber = 3205 }); //11
            teamInfos.Add(new TeamInfo { ID = 12, InUrlTeamName = "gaziantep-fk", RealTeamName = "Gaziantep FK", InUrlTeamNumber = 2832 }); //12
            teamInfos.Add(new TeamInfo { ID = 13, InUrlTeamName = "kasimpasa", RealTeamName = "Kasımpaşa", InUrlTeamNumber = 10484 }); //13
            teamInfos.Add(new TeamInfo { ID = 14, InUrlTeamName = "fatih-karagumruk", RealTeamName = "Fatih Karagümrük", InUrlTeamNumber = 6646 }); //14
            teamInfos.Add(new TeamInfo { ID = 15, InUrlTeamName = "hatayspor", RealTeamName = "Hatayspor", InUrlTeamNumber = 7775 }); //15
            teamInfos.Add(new TeamInfo { ID = 16, InUrlTeamName = "giresunspor", RealTeamName = "Giresunspor", InUrlTeamNumber = 11688 }); //16
            teamInfos.Add(new TeamInfo { ID = 17, InUrlTeamName = "istanbulspor", RealTeamName = "İstanbulspor", InUrlTeamNumber = 924 }); //17
            teamInfos.Add(new TeamInfo { ID = 18, InUrlTeamName = "umraniyespor", RealTeamName = "Ümraniyespor", InUrlTeamNumber = 24245 }); //18 
            HAPMatchScoreDal hAPMatchScoreDal = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == ID));
            return View(hAPMatchScoreDal.GetAllMatchScores(2017));
        }

        public IActionResult TeamList()
        {
            List<TeamInfo> teamInfos = new List<TeamInfo>();
            teamInfos.Add(new TeamInfo { ID = 0, InUrlTeamName = "galatasaray", RealTeamName = "Galatasaray", InUrlTeamNumber = 141 }); //0
            teamInfos.Add(new TeamInfo { ID = 1, InUrlTeamName = "fenerbahce", RealTeamName = "Fenerbahçe", InUrlTeamNumber = 36 }); //1 
            teamInfos.Add(new TeamInfo { ID = 2, InUrlTeamName = "trabzonspor", RealTeamName = "Trabzonspor", InUrlTeamNumber = 449 }); //2
            teamInfos.Add(new TeamInfo { ID = 3, InUrlTeamName = "besiktas-istanbul", RealTeamName = "Beşiktaş JK", InUrlTeamNumber = 114 }); //3
            teamInfos.Add(new TeamInfo { ID = 4, InUrlTeamName = "istanbul-basaksehir-fk", RealTeamName = "İstanbul Başakşehir FK", InUrlTeamNumber = 6890 }); //4
            teamInfos.Add(new TeamInfo { ID = 5, InUrlTeamName = "adana-demirspor", RealTeamName = "Adana Demirspor", InUrlTeamNumber = 3840 }); //5
            teamInfos.Add(new TeamInfo { ID = 6, InUrlTeamName = "konyaspor", RealTeamName = "Konyaspor", InUrlTeamNumber = 2293 }); //6
            teamInfos.Add(new TeamInfo { ID = 7, InUrlTeamName = "alanyaspor", RealTeamName = "Alanyaspor", InUrlTeamNumber = 11282 }); //7
            teamInfos.Add(new TeamInfo { ID = 8, InUrlTeamName = "antalyaspor", RealTeamName = "Antalyaspor", InUrlTeamNumber = 589 }); //8
            teamInfos.Add(new TeamInfo { ID = 9, InUrlTeamName = "mke-ankaragucu", RealTeamName = "MKE Ankaragücü", InUrlTeamNumber = 868 }); //9
            teamInfos.Add(new TeamInfo { ID = 10, InUrlTeamName = "sivasspor", RealTeamName = "Sivasspor", InUrlTeamNumber = 2381 }); //10
            teamInfos.Add(new TeamInfo { ID = 11, InUrlTeamName = "kayserispor", RealTeamName = "Kayserispor", InUrlTeamNumber = 3205 }); //11
            teamInfos.Add(new TeamInfo { ID = 12, InUrlTeamName = "gaziantep-fk", RealTeamName = "Gaziantep FK", InUrlTeamNumber = 2832 }); //12
            teamInfos.Add(new TeamInfo { ID = 13, InUrlTeamName = "kasimpasa", RealTeamName = "Kasımpaşa", InUrlTeamNumber = 10484 }); //13
            teamInfos.Add(new TeamInfo { ID = 14, InUrlTeamName = "fatih-karagumruk", RealTeamName = "Fatih Karagümrük", InUrlTeamNumber = 6646 }); //14
            teamInfos.Add(new TeamInfo { ID = 15, InUrlTeamName = "hatayspor", RealTeamName = "Hatayspor", InUrlTeamNumber = 7775 }); //15
            teamInfos.Add(new TeamInfo { ID = 16, InUrlTeamName = "giresunspor", RealTeamName = "Giresunspor", InUrlTeamNumber = 11688 }); //16
            teamInfos.Add(new TeamInfo { ID = 17, InUrlTeamName = "istanbulspor", RealTeamName = "İstanbulspor", InUrlTeamNumber = 924 }); //17
            teamInfos.Add(new TeamInfo { ID = 18, InUrlTeamName = "umraniyespor", RealTeamName = "Ümraniyespor", InUrlTeamNumber = 24245 }); //18 
            return View(teamInfos);
        }

        [HttpGet]
        public IActionResult TeamvsTeam()
        {
            List<TeamInfo> teamInfos = new List<TeamInfo>();
            teamInfos.Add(new TeamInfo { ID = 0, InUrlTeamName = "galatasaray", RealTeamName = "Galatasaray", InUrlTeamNumber = 141 }); //0
            teamInfos.Add(new TeamInfo { ID = 1, InUrlTeamName = "fenerbahce", RealTeamName = "Fenerbahçe", InUrlTeamNumber = 36 }); //1 
            teamInfos.Add(new TeamInfo { ID = 2, InUrlTeamName = "trabzonspor", RealTeamName = "Trabzonspor", InUrlTeamNumber = 449 }); //2
            teamInfos.Add(new TeamInfo { ID = 3, InUrlTeamName = "besiktas-istanbul", RealTeamName = "Beşiktaş JK", InUrlTeamNumber = 114 }); //3
            teamInfos.Add(new TeamInfo { ID = 4, InUrlTeamName = "istanbul-basaksehir-fk", RealTeamName = "İstanbul Başakşehir FK", InUrlTeamNumber = 6890 }); //4
            teamInfos.Add(new TeamInfo { ID = 5, InUrlTeamName = "adana-demirspor", RealTeamName = "Adana Demirspor", InUrlTeamNumber = 3840 }); //5
            teamInfos.Add(new TeamInfo { ID = 6, InUrlTeamName = "konyaspor", RealTeamName = "Konyaspor", InUrlTeamNumber = 2293 }); //6
            teamInfos.Add(new TeamInfo { ID = 7, InUrlTeamName = "alanyaspor", RealTeamName = "Alanyaspor", InUrlTeamNumber = 11282 }); //7
            teamInfos.Add(new TeamInfo { ID = 8, InUrlTeamName = "antalyaspor", RealTeamName = "Antalyaspor", InUrlTeamNumber = 589 }); //8
            teamInfos.Add(new TeamInfo { ID = 9, InUrlTeamName = "mke-ankaragucu", RealTeamName = "MKE Ankaragücü", InUrlTeamNumber = 868 }); //9
            teamInfos.Add(new TeamInfo { ID = 10, InUrlTeamName = "sivasspor", RealTeamName = "Sivasspor", InUrlTeamNumber = 2381 }); //10
            teamInfos.Add(new TeamInfo { ID = 11, InUrlTeamName = "kayserispor", RealTeamName = "Kayserispor", InUrlTeamNumber = 3205 }); //11
            teamInfos.Add(new TeamInfo { ID = 12, InUrlTeamName = "gaziantep-fk", RealTeamName = "Gaziantep FK", InUrlTeamNumber = 2832 }); //12
            teamInfos.Add(new TeamInfo { ID = 13, InUrlTeamName = "kasimpasa", RealTeamName = "Kasımpaşa", InUrlTeamNumber = 10484 }); //13
            teamInfos.Add(new TeamInfo { ID = 14, InUrlTeamName = "fatih-karagumruk", RealTeamName = "Fatih Karagümrük", InUrlTeamNumber = 6646 }); //14
            teamInfos.Add(new TeamInfo { ID = 15, InUrlTeamName = "hatayspor", RealTeamName = "Hatayspor", InUrlTeamNumber = 7775 }); //15
            teamInfos.Add(new TeamInfo { ID = 16, InUrlTeamName = "giresunspor", RealTeamName = "Giresunspor", InUrlTeamNumber = 11688 }); //16
            teamInfos.Add(new TeamInfo { ID = 17, InUrlTeamName = "istanbulspor", RealTeamName = "İstanbulspor", InUrlTeamNumber = 924 }); //17
            teamInfos.Add(new TeamInfo { ID = 18, InUrlTeamName = "umraniyespor", RealTeamName = "Ümraniyespor", InUrlTeamNumber = 24245 }); //18 

            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var item in teamInfos)
            {
                selectListItems.Add(new SelectListItem{ Text = item.RealTeamName, Value = item.ID.ToString()});
            }
            return View(selectListItems);
        }
        [HttpPost]
        public IActionResult VeriAl(string team1, string team2)
        {
           
             List<TeamInfo> teamInfos = new List<TeamInfo>();
             teamInfos.Add(new TeamInfo { ID = 0, InUrlTeamName = "galatasaray", RealTeamName = "Galatasaray", InUrlTeamNumber = 141 }); //0
             teamInfos.Add(new TeamInfo { ID = 1, InUrlTeamName = "fenerbahce", RealTeamName = "Fenerbahçe", InUrlTeamNumber = 36 }); //1 
             teamInfos.Add(new TeamInfo { ID = 2, InUrlTeamName = "trabzonspor", RealTeamName = "Trabzonspor", InUrlTeamNumber = 449 }); //2
             teamInfos.Add(new TeamInfo { ID = 3, InUrlTeamName = "besiktas-istanbul", RealTeamName = "Beşiktaş JK", InUrlTeamNumber = 114 }); //3
             teamInfos.Add(new TeamInfo { ID = 4, InUrlTeamName = "istanbul-basaksehir-fk", RealTeamName = "İstanbul Başakşehir FK", InUrlTeamNumber = 6890 }); //4
             teamInfos.Add(new TeamInfo { ID = 5, InUrlTeamName = "adana-demirspor", RealTeamName = "Adana Demirspor", InUrlTeamNumber = 3840 }); //5
             teamInfos.Add(new TeamInfo { ID = 6, InUrlTeamName = "konyaspor", RealTeamName = "Konyaspor", InUrlTeamNumber = 2293 }); //6
             teamInfos.Add(new TeamInfo { ID = 7, InUrlTeamName = "alanyaspor", RealTeamName = "Alanyaspor", InUrlTeamNumber = 11282 }); //7
             teamInfos.Add(new TeamInfo { ID = 8, InUrlTeamName = "antalyaspor", RealTeamName = "Antalyaspor", InUrlTeamNumber = 589 }); //8
             teamInfos.Add(new TeamInfo { ID = 9, InUrlTeamName = "mke-ankaragucu", RealTeamName = "MKE Ankaragücü", InUrlTeamNumber = 868 }); //9
             teamInfos.Add(new TeamInfo { ID = 10, InUrlTeamName = "sivasspor", RealTeamName = "Sivasspor", InUrlTeamNumber = 2381 }); //10
             teamInfos.Add(new TeamInfo { ID = 11, InUrlTeamName = "kayserispor", RealTeamName = "Kayserispor", InUrlTeamNumber = 3205 }); //11
             teamInfos.Add(new TeamInfo { ID = 12, InUrlTeamName = "gaziantep-fk", RealTeamName = "Gaziantep FK", InUrlTeamNumber = 2832 }); //12
             teamInfos.Add(new TeamInfo { ID = 13, InUrlTeamName = "kasimpasa", RealTeamName = "Kasımpaşa", InUrlTeamNumber = 10484 }); //13
             teamInfos.Add(new TeamInfo { ID = 14, InUrlTeamName = "fatih-karagumruk", RealTeamName = "Fatih Karagümrük", InUrlTeamNumber = 6646 }); //14
             teamInfos.Add(new TeamInfo { ID = 15, InUrlTeamName = "hatayspor", RealTeamName = "Hatayspor", InUrlTeamNumber = 7775 }); //15
             teamInfos.Add(new TeamInfo { ID = 16, InUrlTeamName = "giresunspor", RealTeamName = "Giresunspor", InUrlTeamNumber = 11688 }); //16
             teamInfos.Add(new TeamInfo { ID = 17, InUrlTeamName = "istanbulspor", RealTeamName = "İstanbulspor", InUrlTeamNumber = 924 }); //17
             teamInfos.Add(new TeamInfo { ID = 18, InUrlTeamName = "umraniyespor", RealTeamName = "Ümraniyespor", InUrlTeamNumber = 24245 }); //18 

             HAPMatchScoreDal hAPMatchScoreDal = new HAPMatchScoreDal(teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team1)));
             return View(hAPMatchScoreDal.GetAllMatchScores(2017).Where(x=> x.OpponentName == teamInfos.FirstOrDefault(x => x.ID == Convert.ToInt16(team2)).RealTeamName).ToList());
        }
    }
}
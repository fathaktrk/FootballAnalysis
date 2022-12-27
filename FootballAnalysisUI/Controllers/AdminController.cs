using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Concrete;
using System.Security.Cryptography.Xml;
using HtmlAgiltyPack.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace FootballAnalysisUI.Controllers
{

    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(User user)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var userList = userManager.ListAll();

            if (userList.Where(x => x.Username == user.Username && x.Password == user.Password).ToList().Count > 0)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role,userList.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault().Role)
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Home", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Home()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public string AddTeam(string teamName, string URL)
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            var list = teamInfoManager.ListAll().Where(x => x.RealTeamName == teamName).ToList();

            if (list.Count > 0)
            {
                return "Takım zaten ekli.";
            }
            else
            {
                teamInfoManager.Add(teamInfoManager.URLParser(teamName, URL));
                return "Başarılı";
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public string AddSeasonInfo(int year)
        {
            HAPSeasonDal seasonDal = new HAPSeasonDal();
            SeasonManager seasonManager = new SeasonManager(new EfSeasonDal());
            int control = seasonManager.ListAll().Where(x => x.SeasonYear == year).ToList().Count;
            if (control > 0)
            {
                return year.ToString() + " yılının verileri zaten çekilmiş.";
            }
            else
            {
                seasonManager.Add(seasonDal.GetSeasonInfos(year));
                return "Başarılı";
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public string AddUser(User user)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(user);
            return "Başarılı";
        }
    }
}
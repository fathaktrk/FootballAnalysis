﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using BusinessLayer.Concrete;
using System.Security.Cryptography.Xml;

namespace FootballAnalysisUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(string teamName, string URL)
        {
            TeamInfoManager teamInfoManager = new TeamInfoManager(new EFTeamInfoDal());
            teamInfoManager.Add(teamInfoManager.URLParser(teamName, URL));
            return RedirectToAction("Index");
        }
    }
}

﻿using EntityLayer.Concrete;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlAgiltyPack.Concrete
{
    public class HAPMatchScoreDal
    {
        public HAPMatchScoreDal(TeamInfo teamInfo)
        {
            WebHtml = new HtmlWeb();
            TeamInfo = teamInfo;
        }

        public HtmlWeb WebHtml { get; set; }
        public List<MatchScore> MatchScores { get; set; }
        public TeamInfo TeamInfo { get; set; }


        public List<MatchScore> GetMatchScores(int year)
        {
            string urlAdress = "https://www.transfermarkt.com.tr/" + TeamInfo.InUrlTeamName + "/spielplandatum/verein/" + TeamInfo.InUrlTeamNumber + "/0?saison_id=" + year + "&wettbewerb_id=TR1&day=&heim_gast=&punkte=&datum_von=-&datum_bis=-";
            var doc = WebHtml.Load(urlAdress);
            HtmlNodeCollection htmlNodes = doc.DocumentNode.SelectNodes(xpath: "//tr[@style='']");

            foreach (var item in htmlNodes)
            {
                string opponent = item.SelectSingleNode("./td[@class='no-border-links hauptlink']/a").InnerText;
                string score = item.SelectSingleNode("./td/a/span").InnerText;
                string home = item.SelectSingleNode("./td[@class='zentriert hauptlink']").InnerText;
                string[] scores = score.Split('-');
                MatchScores.Add(new MatchScore()
                {
                    Name = TeamInfo.InUrlTeamName,
                    OpponentName = opponent,
                    HomeScore = Convert.ToInt32(scores[0]),
                    OpponentScore = Convert.ToInt32(scores[1]),
                    Season_ID = year
                });
            }
            return MatchScores;
        }
    }
}
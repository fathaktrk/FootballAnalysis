using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFTeamInfoDal : IGenericDal<TeamInfo>, ITeamInfoDal
    {
        public void Add(TeamInfo t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Add(List<TeamInfo> list)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                foreach (var item in list)
                {
                    ctx.Add(item);
                }
                ctx.SaveChanges();
            }
        }

        public List<TeamInfo> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TeamInfo t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Remove(t);
                ctx.SaveChanges();
            }
        }

        public void Update(TeamInfo t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Update(t);
                ctx.SaveChanges();
            }
        }

        public TeamInfo URLParser(string teamName, string URL)
        //urlin parçalara ayrılım takımın adını ve takımın numrasını aldığı metot
            { 
        
                string[] URLSplit = URL.Split('/');
                string[] URLList = new string[] { URLSplit[3], URLSplit[6] };
                /*https://www.transfermarkt.com.tr/fenerbahce-istanbul/startseite/verein/36*/
                //.   0 ^^            2           ^      3            ^   4      ^  5   ^ 6
                return new TeamInfo(){
                        InUrlTeamName = URLSplit[3] ;
                        InUrlTeamNumber = Convert.ToInt16(URLSplit[6]);
                        RealTeamName = teamName;
            }
        }
    }
}

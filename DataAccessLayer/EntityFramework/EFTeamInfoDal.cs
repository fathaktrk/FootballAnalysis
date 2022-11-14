using DataAccessLayer.Abstract;
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
            throw new NotImplementedException();
        }

        public void Add(List<TeamInfo> list)
        {
            throw new NotImplementedException();
        }

        public List<TeamInfo> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TeamInfo t)
        {
            throw new NotImplementedException();
        }

        public void Update(TeamInfo t)
        {
            throw new NotImplementedException();
        }

        public TeamInfo URLParser(string teamName, string URL) { 
        
                string[] URLSplit = URL.Split('/');
                string[] URLList = new string[] { URLSplit[3], URLSplit[6] };
                return new TeamInfo(){
                        InUrlTeamName = URLSplit[3], 
                        InUrlTeamNumber = Convert.ToInt16(URLSplit[6]),
                        RealTeamName = teamName
                    };
        }
    }
}

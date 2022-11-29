using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamInfoManager : ITeamInfoService
    {
        ITeamInfoDal _teamInfoDal;
        public TeamInfoManager(ITeamInfoDal teamInfoDal)
        {
            _teamInfoDal = teamInfoDal;
        }

        public void Add(TeamInfo t)
        {
            _teamInfoDal.Add(t);
        }

        public void Add(List<TeamInfo> list)
        {
            _teamInfoDal.Add(list);
        }

        public List<TeamInfo> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TeamInfo t)
        {
            _teamInfoDal.Remove(t);
        }

        public void Update(TeamInfo t)
        {
            _teamInfoDal.Update(t);
        }

        public TeamInfo URLParser(string teamName, string URL)
        {
           return _teamInfoDal.URLParser(teamName, URL);
        }
    }
}

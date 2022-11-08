using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITeamInfoDal : IGenericDal<TeamInfo>
    {
        public TeamInfo URLParser(string teamName, string URL);
    }
}

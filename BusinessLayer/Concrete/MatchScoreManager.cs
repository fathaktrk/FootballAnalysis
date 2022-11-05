using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MatchScoreManager : IMatchScoreService
    {
        IMatchScoreDal _matchScoreDal;

        public MatchScoreManager(IMatchScoreDal matchScoreDal)
        {
            _matchScoreDal = matchScoreDal;
        }
        public void Add(MatchScore t)
        {
            throw new NotImplementedException();
        }

        public void Add(List<MatchScore> list)
        {
            throw new NotImplementedException();
        }

        public List<MatchScore> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(MatchScore t)
        {
            throw new NotImplementedException();
        }

        public void Update(MatchScore t)
        {
            throw new NotImplementedException();
        }
    }
}

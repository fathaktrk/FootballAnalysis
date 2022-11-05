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
    public class SeasonManager : ISeasonService
    {
        ISeasonDal _seasonDal;
       

        public SeasonManager(ISeasonDal seasonDal)
        {
            _seasonDal = seasonDal;
        }

        public void Add(Season t)
        {
            _seasonDal.Add(t);
        }

        public void Add(List<Season> list)
        {
            _seasonDal.Add(list);
        }

        public List<Season> ListAll()
        {
            return _seasonDal.ListAll();
        }

        public void Remove(Season t)
        {
            _seasonDal.Remove(t);
        }

        public void Update(Season t)
        {
            _seasonDal.Update(t);
        }
    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Add(t);
                ctx.SaveChanges();
            }
        }

        public void Add(List<T> list)
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

        public List<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Remove(t);
                ctx.SaveChanges();
            }
        }

        public void Update(T t)
        {
            using (FootballAnalysisContext ctx = new FootballAnalysisContext())
            {
                ctx.Update(t);
                ctx.SaveChanges();
            }
        }
    }
}

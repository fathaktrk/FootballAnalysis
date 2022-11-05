using DataAccessLayer.Abstract;
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
            throw new NotImplementedException();
        }

        public void Add(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<T> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T t)
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}

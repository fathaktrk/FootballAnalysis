using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public  interface IGenericDal<T> where T : class
    {
        public void Add(T t);
        public void Add(List<T> list);
        public void Remove(T t);
        public void Update(T t);
        public List<T> ListAll();   

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void Add(T t);


        public void Add(List<T> list); //ekle

        public List<T> ListAll();

        public void Remove(T t);

        public void Update(T t);
    }
}

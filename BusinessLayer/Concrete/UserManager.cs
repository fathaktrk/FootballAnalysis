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
    public class UserManager : IUserManager
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
              _userDal = userDal;
        }
        public void Add(User t)
        {
            _userDal.Add(t);
        }

        public void Add(List<User> list)
        {
            _userDal.Add(list);
        }

        public List<User> ListAll()
        {
            return _userDal.ListAll();
        }

        public void Remove(User t)
        {
            _userDal.Remove(t);
        }

        public void Update(User t)
        {
            _userDal.Update(t);
        }
    }
}

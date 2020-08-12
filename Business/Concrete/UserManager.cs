using Business.Abstract;
using Core.Entity;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }
        public void Add(User user)
        {
            userDal.Add(user);
        }

        public User GetByEmail(string email)
        {
            var result = userDal.Get(e => e.Email == email);
            return result;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return userDal.GetClaims(user).ToList();
        }
    }
}

using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concerete
{
    public class UserManager:IUserLoginService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Register GetRegister(string username, string password)
        {
           return _userDal.Get(x=>x.Mail==username && x.Password==password);    
        }

        public void RegisterAdd(Register register)
        {
            _userDal.Insert(register);
        }
    }
}

using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserLoginService
    {
        Register GetRegister(string username, string password);
        void RegisterAdd(Register register);
    }
}

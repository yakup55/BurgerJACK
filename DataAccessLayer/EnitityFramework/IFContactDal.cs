using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityFramework
{
    public class IFContactDal:GenericRepositories<Contact>,IContactDal
    {
    }
}

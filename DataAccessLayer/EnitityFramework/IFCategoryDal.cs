using DataAccessLayer.Repositories;
using EntityLayerr.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EnitityFramework
{
    public class IFCategoryDal:GenericRepositories<Category>,ICategoryDal
    {
    }
}

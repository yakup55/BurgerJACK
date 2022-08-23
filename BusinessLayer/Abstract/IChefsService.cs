using EntityLayerr.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IChefsService
    {
        List<OurChefs> GetList();
        void ChefsAdd(OurChefs chefs);
        void ChefsDelete(OurChefs chefs);
        void ChefsUpdate(OurChefs chefs);
        OurChefs GetOurChefsById(int id);
    }
}

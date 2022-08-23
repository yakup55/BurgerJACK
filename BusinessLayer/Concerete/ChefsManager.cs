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
    public class ChefsManager : IChefsService
    {
        IChefsDal _chefsDal;

        public ChefsManager(IChefsDal chefsDal)
        {
            _chefsDal = chefsDal;
        }

        public void ChefsAdd(OurChefs chefs)
        {
            _chefsDal.Insert(chefs);
        }

        public void ChefsDelete(OurChefs chefs)
        {
        _chefsDal.Delete(chefs);
        }

        public void ChefsUpdate(OurChefs chefs)
        {
            _chefsDal.Update(chefs);
        }

        public List<OurChefs> GetList()
        {
            return _chefsDal.List();
        }

        public OurChefs GetOurChefsById(int id)
        {
            return _chefsDal.Get(x => x.OurID == id);
        }
    }
}

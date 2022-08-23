using BusinessLayer.Abstract;
using EntityLayerr.Abstract;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concerete
{
    public class BurgerManager : IBurgerService
    {
        IBurgerDal _burgerdal;

        public BurgerManager(IBurgerDal burgerdal)
        {
            _burgerdal = burgerdal;
        }

        public void BurgerAdd(Burger burger)
        {
           _burgerdal.Insert(burger);
        }

        public void BurgerDelete(Burger burger)
        {
            _burgerdal.Delete(burger);
        }

        public void BurgerUpdate(Burger burger)
        {
            _burgerdal.Update(burger);
        }

        public Burger GetBurgerByid(int id)
        {
   return _burgerdal.Get(x=>x.BurgerİD==id);  
        }

        public List<Burger> GetList()
        {
          return _burgerdal.List();
        }
    }
}

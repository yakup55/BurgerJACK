using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBurgerService
    {
        List<Burger> GetList();
        void BurgerAdd(Burger burger);
        void BurgerUpdate(Burger burger);
        void BurgerDelete(Burger burger);
        Burger GetBurgerByid(int id);
    }
}

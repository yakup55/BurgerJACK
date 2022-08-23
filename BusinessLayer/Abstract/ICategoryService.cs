﻿using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        Category GetById(int id); 
        void CategoryAdd(Category category);    
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category); 
    }
}

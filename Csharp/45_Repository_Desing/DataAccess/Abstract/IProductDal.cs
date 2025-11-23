using _45_Repository_Desing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Repository_Desing.DataAccess.Abstract
{
    internal interface IProductDal:IRepository<Products>
    {
        int GetCountByCategory(string category);
        Products GetProductsDetail(int id);
        void Update(Products entity, int[] categoryIds);
    }
}

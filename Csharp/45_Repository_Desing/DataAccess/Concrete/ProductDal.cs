using _45_Repository_Desing.DataAccess.Abstract;
using _45_Repository_Desing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _45_Repository_Desing.DataAccess.Concrete
{
    internal class ProductDal : GenericRepository<Products, DataContext>, IProductDal
    {
        public int GetCountByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Products GetProductsDetail(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
        public override void Delete(Products entity)
        {
            base.Delete(entity);
        }
        public override void Update(Products entity)
        {
            base.Update(entity);
        }
        public override List<Products> GetAll(Expression<Func<Products, bool>> filter = null)
        {
            return base.GetAll(filter);
        }
    }
}

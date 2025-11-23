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
    internal class OrderDal : GenericRepository<Orders, DataContext>, IOrderDal
    {
        public List<Orders> GetOrders(string userId)
        {
            throw new NotImplementedException();
        }
        public override void Update(Orders entity)
        {
            base.Update(entity);
        }
        public override void Delete(Orders entity)
        {
            base.Delete(entity);
        }
        public override List<Orders> GetAll(Expression<Func<Orders, bool>> filter = null)
        {
            return base.GetAll(filter);
        }
    }
}

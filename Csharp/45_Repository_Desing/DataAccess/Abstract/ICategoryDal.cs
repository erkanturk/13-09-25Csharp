using _45_Repository_Desing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Repository_Desing.DataAccess.Abstract
{
    internal interface ICategoryDal : IRepository<Categories>
    {
        void DeleteFromCategory(int categoryId, int ProductId);//Kategoriye bağlı ürünü sil

        Categories GetByIdWithProducts(int productId);//Categoriye ait olan ürünleri getir.
    }
}

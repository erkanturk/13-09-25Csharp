using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _45_Repository_Desing.DataAccess.Abstract
{
    internal interface IRepository<T>
    {
        T GetById(int id);//Read
        T GetOne(Expression<Func<T, bool>> filter = null);//koşula bağlı olarak bana değeri getirecek //Read

        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Örneğin:Kategorisi Elektronik olanları liste  halinde getir. Read
        void Create(T entity);//Create
        void Update(T entity);//Update
        void Delete(T entity);//Delete

    }
    /* Bu yqapıda tüm verilere eişim katmanında ortak olarak Crud işlemlerinin tek bi yerden yönetilmesini sağlayacak
     * Generic olması sayesinde Product Category Order gibi darklı nesneler için tekrar tekrar yazmak zorunda kalmayacağız
    */
}

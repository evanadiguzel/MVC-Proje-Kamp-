using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Burası CRUD metotlarının genel bulunduğu sınıf,abstractlarda ki interfacelerin hepsi buradan beslenecek
    public interface IRepository<T> //Burada ICategoryDal yerine tüm entityi kapsayan Interface metotları yazıldı.
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);

    }
}

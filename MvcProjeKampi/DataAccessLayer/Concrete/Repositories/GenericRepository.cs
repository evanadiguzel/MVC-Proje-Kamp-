using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>(); // Contexte bağlı olarak gönderilen T değeri.Dışarıdan Gönderilen T değeri _object üzerine atandı.

        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
           return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); //filterda ne verdiysek onu listeleyerek dönecek
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}

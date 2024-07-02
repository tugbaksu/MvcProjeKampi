using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{// BURADA IRepository inerface'ini kullanıcam ve bunları sınıf olarak alıcam yani T yerine gelen değerler bir sınıftır şartı var burada
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object; //T değerine karşılık gelen sınıfı tutar
        //constructer-> burada kullanım amacı T değerini hangi sınıf bilmiyorum burada yazdığım her sınıf olabilir sonuçta hepsi gelebileceğinden constructar kullanıyoruz
        public GenericRepository()
        {
            _object = c.Set<T>(); //context'e bağlı olarak gönderilen T değerim benim _objectim olacak ve sınıf net belirleniyor bundan sonra da o sınıf üstünden işlemler yapabilirim
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

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); //filterdan gelen değere göre listeleme yap
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}

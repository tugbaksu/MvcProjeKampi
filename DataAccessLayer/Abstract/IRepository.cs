using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //ben sqlden ne entity(sınıfı) gönderiyorsam t o olacak categorydal bir örnekti asıl ve yeterli interface bu
    {
        List<T> List();
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        //Şartlı Listeleme yapar örneğin e-ticaret sitelerindeki filtreleme işlemini sağlar.
        List<T> List(Expression<Func<T, bool>> filter);
    }
}

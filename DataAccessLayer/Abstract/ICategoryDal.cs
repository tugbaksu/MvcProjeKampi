using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {




        ////CRUD: CREATE-READ-UPDATE-DELETE
        ////CRUD operasyonlarının gerçekleşeceği metodlar
        //List<Category> DoList(); //türü list olan bir metod

        //void Insert(Category p);

        //void Update(Category p);

        //void Delete(Category p);
    }
}
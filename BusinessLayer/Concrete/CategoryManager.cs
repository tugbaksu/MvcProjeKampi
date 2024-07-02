using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBL() //HepsiniGetir metodum
        {
            return repo.List(); //GenericRepository içinde tanımladığım listeleme işlemini yapar
        }
        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName==null || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryStatus==false || p.CategoryName.Length >= 51)
            {
                //hata mesajı döndürücem
            }
            else
            {
                repo.Insert(p); //Category sınıfından oluşturduğum p parametresinden gelen değerin Insert(ekleme) işlemi yapılsın
            }
        }
    }
}

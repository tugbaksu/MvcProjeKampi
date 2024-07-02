using EntityLayer.Concrete; //About'u EntityLayer'da yer alan Concrete diziniyle beraber kullan demek
using System.Data.Entity;


namespace DataAccessLayer.Concrete
{
    //Veri tabanına tabloları yansıtabilmek için CONTEXT sınıfı kullanılır. CONTEXT sınıfı DataAccessLayer (Veri Erişim Katmanı) altında oluşturacağımız somut bir klasör olan CONCRETE klasörünün içine eklenir.
    public class Context : DbContext
    //CONTEXT sınıfı-> Aşağıya yazılmış olan DbSet türündeki proportyleri SQL'e birer tablo olarak yansıtır.
    {
        //About->projede yer alan sınıfın ismi   Abouts->SQL'de veritabanına yansıyacak olan tablonun ismidir.duruma göre -s -ies gibi ekler ile kullanılır.
        public DbSet<About> Abouts { get; set; } //Entity layera ait About bu yüzden references kısmından entitylayer'ı referans olarak eklemek zorundayız.
        public DbSet<Category> Categories { get; set; }// s takısı ies olarak geldi ingilizce kaynaklı
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
       
    }
}

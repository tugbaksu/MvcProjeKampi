using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; } //kategori aktif olsun mu yani aktifse öyle bir kategori gözüksün aktif değilse arkada verileri tutulsun ama gözükmesin kategori kalkmış olsun istediğimiz zaman

        public ICollection<Heading> Headings { get; set; } //TABLOLAR ARASINDA İLİŞKİ KURMAK İÇİN
                                                       //<> ARASINDA HANGİ SINIFLA İLİŞKİ KRUULACAĞI YAZILIR VE BUNUN YAZILDIĞI SINIF ÖBÜRÜNÜN GENEL BAŞLIĞIDIR ÖBÜR SINIF BUNUN ALT BAŞLIĞI OLUR
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Heading //BAŞLIKLAR SINIFI
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; } //İLİŞKİ KURULDUĞU İÇİN İLİŞKİ KURULAN SINIFIN PRİMARY KEYİNİ ALMALI
        public virtual Category Category { get; set; }//category sınıfından category isminde bir değer alıcam demek oluyor

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; } //heading contentin üst başlığı olduğu için ilişki kurduk
        
        
    
    }
}

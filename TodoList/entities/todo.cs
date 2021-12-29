using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.entities
{
   public class todo
    {  [DisplayName("ID")]
        public Guid  id { get; set; }
        [DisplayName("Başlık")]
        public string  baslık { get; set; }
        [DisplayName("Kısa Açıklama")]
        public string kisaaciklama { get; set; }
        [DisplayName("Açıklama")]
        public string aciklama { get; set; }
        [DisplayName("Önem Derecesi")]
        public int  onemderece { get; set; }
        [DisplayName("Durum Açıklama")]
        public string durumAciklama { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime Olusturmatarihi { get; set; }



    }
}

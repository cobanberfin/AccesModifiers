using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   public interface Imusteri 
    {
        //public ICustomer() 
        //{ 
        //interfacede yapıcı metot kullanılmaz tamamen sablondur
        //field lar yer alır
        //değişken tanımlama sadece property oluşturabılırm
        int Id { get; set; }
        //erişim belirleyicisi kulanılmaz
        //interface örneklenmez
        //classıma bırden fazla interfaceden mıras alabılırım
        string isim{ get; set; }
        string soyisim { get; set; }

        int yenikayıt(string isim, string soyisim);//metodun imzası yer alır
        int kayitduzenle(int Id, string isim, string soyisim);
      


        //}
    }
}

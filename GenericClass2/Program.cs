using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    class Program
    {
        static void Main(string[] args)
        {/*database |uygulama
          
          tablo musteri
            id int
            musterı nı guid(prımarykey)
            isim nvarchar(50)
            soyisim nvarchar(50)
            dogumktarıhı datetime

          
          
          
          */
            GenericRepository<Musteri> repositorymusteri = new GenericRepository<Musteri>();
            List<Musteri> musteriliste = repositorymusteri.Getir();
            repositorymusteri.YeniKayıtEkle();

            GenericRepository<Urun> repositoryurun = new GenericRepository<Urun>();
            List<Urun> urunliste = repositoryurun.Getir();
            repositoryurun.YeniKayıtEkle();
            //GenericRepository<int> d = new GenericRepository<int>();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "çınar";
            musteri.soyisim = "ılgaz";


            MusteriGeneric<int> musterigeneric = new MusteriGeneric<int>();
            musterigeneric.id = 1;
            musterigeneric.musteriNumarasıAl();

            
            MusteriGeneric<Guid> musterigeneric2 = new MusteriGeneric<Guid>();
            musterigeneric2.musteriNumarasıAl();


        }
    }
}

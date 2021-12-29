using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList a = new ArrayList();

            //a.Add(1);
            //a.Add("bir");

            ////T tipi demek .net fremawork içerisnde olan veya bızım oluşturdugumuz herhangı bır tip demek.

            //List<int> liste = new List<int>();
            //liste.Add(1);
            //liste.Add(2);
            ////list.Add("bir ")

            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);

            //}

            //List<string> slist = new List<string>();
            //slist.Add("deneme");
            //slist.Add("gül");
            //slist.Add("2");
            //List<Musteri> m = new List<Musteri>();
            //m.Add(new Musteri()
            //{
            //    id = 1, isim="gül" , Soyisim="yılmaz"

            //});

            //Musteri m2 = new Musteri(); baska kullanım
            //m2.id=

            //foreach (Musteri item  in m)
            //{
            //    Console.WriteLine(item.isim);
            //}
            //Console.ReadLine();


            List<int> sayilarım = new List<int>();
            sayilarım.Add(1);
            int[] eklenecek = new int[5];
            eklenecek[0] = 23;
            eklenecek[1] = 3;
            eklenecek[2] = 2;
            eklenecek[3] = 8;
            eklenecek[4] = 18;


            //uzun 1. yolu 

            for (int i = 0; i < eklenecek.Length; i++)
            {
                sayilarım.Add(eklenecek[i]);
            }

            //2.yol
            sayilarım.AddRange(eklenecek);//toplu şekılde ekle

            //------------------------------------------------------------------

            int capacity = sayilarım.Capacity;//4 ile  ile baslıyor.
            int count = sayilarım.Count;

            //soru: sayılarım koleksıyonunun içerisnde bulunan datayı ekrana yazdır
            //=> ilgili koleksıyon ıcınde arama yap =>linq konusu

            sayilarım.ForEach(x => Console.WriteLine(x));
            int bulunan = sayilarım[3];
            Console.WriteLine("3.indeksteki eleman{0}",bulunan);


            sayilarım.Insert(3, 100); //ilgili indextekı değeri silmez indexsi bir aşağı kaydırıp ekleme yapar.
            bool kontrol1 = sayilarım.Any();//içerisnde sart yoksa ilgili yerde data varmı yokmu kontrol eder
            bool kontrol2 = sayilarım.Any(i => i > 500); //verılen yer ıcınde 500den buyuk deger varmı

            sayilarım.Sort(); //a-z 1-N sıralama
            sayilarım.Reverse(); //z-a N-1

            int enyuksek = sayilarım.Max();
            int endusuk = sayilarım.Min();
            int toplam = sayilarım.Sum();
            Console.WriteLine("en yuksek:"+enyuksek+"endüşük:"+endusuk+"toplamı"+toplam);


            bool silmeişlemi = sayilarım.Remove(5);
            sayilarım.RemoveAt(2);//verılen indexe gore sılme yapar

            //sayılarım içerisnde yer alan 3 ten buyuk elemanları sil ve kac adet oldugunu bı değişkene ata
           int s= sayilarım.RemoveAll(x => x > 3);
            sayilarım.Clear();



               
                


            Console.ReadLine();


        }
    }
}

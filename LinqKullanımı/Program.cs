using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {

            SanalDatabase db = new SanalDatabase();
            List<Musteri> musteriliste = new List<Musteri>();
            musteriliste = db.Musterilistesi();
            Console.WriteLine(musteriliste.Count());

            //isminin baş harfı A ile başlayan musterı adedı

            int bulunan = 0;

            for (int i = 0; i < musteriliste.Count; i++)
            {
                if (musteriliste[i].İsim[0] == 'A')
                {
                    bulunan++;
                }
            }
            Console.WriteLine("a ile başlayanların sayısı"+bulunan);
            Console.WriteLine(musteriliste.Count);

            //linq teknolojisi
            bulunan = 0;
            bulunan = musteriliste.Where(x => x.İsim.StartsWith("A")).Count();

            Console.WriteLine("a ile başlayanların sayısı" + bulunan);

            Console.WriteLine(musteriliste.Count);

            //Lİnq sorgulama çeşitleri
            //musterıloste arama yap
            int toplammusterı = musteriliste.Where(x => x.İsim.StartsWith("A")).Count();
            var bulunanmusteri = from I in musteriliste  //linqguery
                                 where I.İsim.EndsWith("A")
                                 select I;


            int bulunanmusteri2 = bulunanmusteri.Count();

            //1:musteriler içerisinde ülke değeri A ile başlayan musterileri linq ile gtr

            int musterıulke = musteriliste.Where(x => x.Ulke.Contains("A")).Count();


            var bulunanUlke = from K in musteriliste
                              where K.Ulke.Contains("A")
                              select K;



            //2:musteriler içersindeki kayıtlardsn isminin içinde b hsrfi geçen ve ülke değeriiçnde A harfı gecen musterılıstes getrı..tolower:containste a veya A olrak arama yaptıgımızda bulmama ıhtımalı dolyaı kelımeyı kucuk yada buyuk harfe cevırdık
            int kayıtmusteri = musteriliste.Where(x => x.İsim.Contains("B") && x.Ulke.ToLower(). Contains("A")).Count();



            //3:musteriler listesindeki kayıtlardan doğum yılı 1990 dan buyuk olan ve ismini içinde A gecen kayıtları linq query yöntemıyle getırın


            var kayıt = from T in musteriliste
                        where T.Dogumtarihi.Year > 1990 && T.İsim.ToLower().Contains("A")
                        select T;
                      

           


        }
    }
}

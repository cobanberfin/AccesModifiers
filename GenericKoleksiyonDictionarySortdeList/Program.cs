using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonDictionarySortdeList
{
    class Program
    {
        static void Main(string[] args)
        {//generic olmayan koleksiyon davranışı
            Hashtable h1 = new Hashtable();
            h1.Add(1, "bir");
            h1.Add(2, "iki");
            h1.Add(3, true);
            // h1.Add(1, "test");1daha once eklendı hata verır


            //Dictionary <Tkey ,Tvslue >;

            Dictionary<int, string> dictionarylist = new Dictionary<int, string>();
            dictionarylist.Add(1, "deneme");
            dictionarylist.Add(2, "deneme2");
            dictionarylist.Add(3, "deneme");

        bool silmesonuıc= dictionarylist.Remove(1);
            if (silmesonuıc)
            {
                Console.WriteLine("silindi");
            }
            else
            {
                Console.WriteLine("arana deger list içerisnde bulunamadı");
            }
            Console.ReadLine();

            //contains :içerirmı

            bool aranandeger = dictionarylist.ContainsKey(1);//1noluyu bul
            if (aranandeger)
            {
                string gelendeger = dictionarylist[1];
                gelendeger = "yenilenen deger";
                dictionarylist[1] = gelendeger;
             
            
            }
            else
            {
                Console.WriteLine("aranan deger bulunamadı");
            }

            bool aranandegerv = dictionarylist.ContainsValue("deneme2");
            if (aranandegerv)
            {
                Console.WriteLine("araan deger bulundu");
            }
            else
            {
                Console.WriteLine("aranan deger bulunamadı");
            }
            foreach (KeyValuePair<int,string> item in dictionarylist)
            {
                Console.WriteLine("anahtarÇ:{0} || deger: {1} ",item.Key,item.Value);
            }
            dictionarylist.Clear();

           // --sortedlist
            SortedList<int, string> sortedlistkoleksıyon = new SortedList<int, string>();
            sortedlistkoleksıyon.Add(100, "yüz");
            sortedlistkoleksıyon.Add(50, "elli");
            sortedlistkoleksıyon.Add(1000, "bin");
            sortedlistkoleksıyon.Add(1, "yüz");
         //   sortedlistkoleksıyon.Add(10, 5); aynı tur olamaz

        }
    }
}

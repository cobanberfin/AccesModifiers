using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_temsilciler
{
    class Program
    { /*  
       delegate
        aynı metot ımzasına sahıp olan metotları tutan ve liste içerisnde barındıran yapılardır.Metod tuttucu olarak da bılınır
        metot ımzası :hangı hangı pramtre alıyor ve buna ne dönduruyor
       
       */

        delegate void Matematikselislemler(int sayi1, int sayi2);
       static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("toplam:{0} " , sonuc);
        }

        static void Cıkar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("cıkarma_sonucu:{0} " , sonuc);
        }
        static void Çarpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("Çarpım:{0} " ,sonuc);
        }

        static void Bölme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("Bölüm:{0} " ,sonuc);
        }
        static void Main(string[] args)
        {
            //Topla(10, 20);
            Matematikselislemler m1 = new Matematikselislemler(Topla);
            m1 += Cıkar;
            m1 += Çarpma;
            m1.Invoke(30, 2); //metotları nu degerlerle calıstır


            Delegate[] İsaretedilenmetotlar = m1.GetInvocationList();

            foreach (var item in İsaretedilenmetotlar)
            {
                Console.WriteLine(item.Method.Name);
            }
            m1 -= Çarpma;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            m1 -= Cıkar;


















            Console.ReadLine();


        }
    }
}

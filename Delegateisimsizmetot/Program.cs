using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateisimsizmetot
{
    delegate void EkranaYaz(string a, string s);
    class Program
    {
        static void Main(string[] args)
        {//var olan bır metodu kullanrak delegate ıcıne ekleme
            EkranaYaz test1 = new EkranaYaz(TestMetod);
            test1("gül", "yılmaz");
            //isimsizmetod kullanımı
            EkranaYaz test2 = new EkranaYaz(delegate (string a, string s)
             {
                 Console.WriteLine(a + "     " + s);

             });
            test2("semra", "mert");

            //Lambda Exp Kullanımı
            EkranaYaz test3 = (a, s) =>
            {
                Console.WriteLine(a + "   " + s);
            };
            test3("aylin", "çınar");
         

        }

        static void TestMetod(string a,string s)
        {
            Console.WriteLine(a+"     "+s);
        }
    }
}

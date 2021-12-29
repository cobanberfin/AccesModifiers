using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        { // abstract class : kendımıze işimize yarayacak bır model cıkarıoyurz
            //Abstract sınıfların isntancı alınmaz sablon olarak kullanılır
            //kural kütüphanesıdır.ondan kalıtım alan sınıflar yapıcı metodunu çalıştırabılır ama program cs de örneklenmez
            //abstract olarak tanımlı metodları kullanmak zorunda bırakır eğer başında abstract ıfadesı yoksa ımplement etmeyı zorunlu kılmaz
            //asbtcat sınıflar sealed kullanılamaz
            superMusteri sp = new superMusteri();
            sp.testAbstract();
            Musteri m1 = new Musteri();
            m1.test();
            m1.testAbstract();
        }
    }
}

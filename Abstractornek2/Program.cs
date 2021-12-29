using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractornek2
{
    class Program
    {
        static void Main(string[] args)
        {

            Fulltimepersonel fltmp = new Fulltimepersonel();
            fltmp.Id = 100;
            fltmp.Ad = "metin";
            fltmp.Soyad = "şen";
            fltmp.Yıllıkmaas = 40000;
            Console.WriteLine(fltmp.AdSoyad());
            Console.WriteLine("full time mass="+fltmp.Aylıkmaas());


            SözleşmeliPersonel s = new SözleşmeliPersonel();
            s.Id = 101;
            s.Ad = "melek";
            s.Soyad = "alk";
            s.Çalışmasüresi = 20;
            s.Saatliködeme = 40;
            Console.WriteLine(s.AdSoyad());
            Console.WriteLine("sözleşmeli personel maas="+s.Aylıkmaas());
            Console.ReadLine();
        }
    }
}

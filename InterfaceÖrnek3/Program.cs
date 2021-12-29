using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖrnek3
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba araba = new Araba();
            araba.yildiz = 5;
            araba.Model = "2012";
            araba.Marka = "bmw";
            araba.Modelyili = 2006;
            araba.Sanzıman = "düzvites";
            araba.Özellikoku();
            //Console.WriteLine(araba.yildiz+" "+araba.Sanzıman+" "+araba.Marka+" "+araba.Modelyili +" "+araba.Model);
         
            
            Console.ReadLine();
        }
    }
}

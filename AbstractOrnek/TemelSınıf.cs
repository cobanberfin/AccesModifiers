using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
 public  abstract class TemelSınıf
    {
        public DateTime Kayıtarihi { get; set; }
        public DateTime guncellemetarihi { get; set; }
        public TemelSınıf()
        {
            Kayıtarihi = DateTime.Now;
            guncellemetarihi = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("temelsınıf=>");
        }
        public abstract void testAbstract();//sadecew metodun ımzası ye alır
        //{

        //}
    }
}

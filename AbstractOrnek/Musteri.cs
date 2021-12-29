using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOrnek
{
    public class Musteri : TemelSınıf
    {
        public int musteriId { get; set; }
        public Musteri()
        {//heryenılendııgnde kendıne deger atasın
            musteriId = 1;

        }
        public override void testAbstract()
        {
            Console.WriteLine("musteri=>testAbstract");
        }
    }
}

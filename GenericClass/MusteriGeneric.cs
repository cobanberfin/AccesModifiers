using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class MusteriGeneric<T> //newleken sana bırı tıp vecek onu al
    {
        public T id { get; set; }
        public T musterıNO { get; set; }

        public string Tc { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime Dogumtarihi { get; set; }
        public T musteriNumarasıAl()
        {
            return musterıNO;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifiers
{
   public class Kisi
    {
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        protected string Tc { get; set; }

       protected internal int Kredikartno { get; set; }




    }
}

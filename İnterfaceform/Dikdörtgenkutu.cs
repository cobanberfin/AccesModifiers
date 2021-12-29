using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceform
{
    public class Dikdörtgenkutu : IUrun
    {
      
        public int kısakenar { get; set; }
        public int uzunkenar { get; set; }
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int yukseklik { get; set; }
        public int Hacim()
        {
            return  yukseklik * kısakenar * uzunkenar;
           
        }
    }
}

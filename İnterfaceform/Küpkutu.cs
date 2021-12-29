using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceform
{
    public class Küpkutu : IUrun
    {
        public int id { get; set; }
        public string UrunAd { get; set; }
        public int yukseklik { get; set; }

        public int Hacim()
        {
            double hacim = (Math.Pow (Convert.ToDouble(yukseklik), 3));
            return Convert.ToInt32(hacim);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceform
{
   public  interface IUrun
    {
         int id { get; set; }
        string UrunAd { get; set; }
        int  yukseklik{ get; set; }
        int Hacim();
        

    }
}

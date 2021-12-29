using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖrnek3
{
   public interface IAraba
    {

         string Marka{ get; set; }
         string Model { get; set; }
        int  Modelyili{ get; set; }
        string Sanzıman { get; set; }
        void  Özellikoku();




    }
}

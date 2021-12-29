using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractornek2
{
   public abstract class BasePersonel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
      



       public string AdSoyad()
        {
            return Ad +" "+ Soyad;
        }

        public abstract int Aylıkmaas();
        





    }


}

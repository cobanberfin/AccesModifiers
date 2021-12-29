using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractornek2
{
    public class SözleşmeliPersonel : BasePersonel
    {
        public int Saatliködeme { get; set; }
        public int Çalışmasüresi { get; set; }

        public override int Aylıkmaas()
        {
            //int aylıködeme=  Saatliködeme* Çalışmasüresi;
            //  return aylıködeme;
            return Saatliködeme * Çalışmasüresi;
        }
    }
}

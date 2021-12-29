using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractornek2
{
    public class Fulltimepersonel : BasePersonel
    {

        public int Yıllıkmaas { get; set; }


        public override int Aylıkmaas()
        {
            return Yıllıkmaas / 12;
          }
    }
}

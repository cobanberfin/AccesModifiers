using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceÖrnek3
{
    public class Araba : IAraba, INumara
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        private int  _modelyili;
        public int  Modelyili {
            get { return _modelyili; }


            set {

                if(value < 2005)
                {
                    _modelyili = 2005;
                }
                else
                {
                    _modelyili = value;

                }

            }
                }

        public string Sanzıman { get; set; }
        private int _yildiz;
        public int yildiz {
            // set {_yıldız=value>5?5:value;}

            get { return _yildiz; }
            set {
                if (value > 5)
                {
                    _yildiz = 5;
                }
                else
                {
                    _yildiz = value;
                }
            }
        }


      public   void Özellikoku()
        {
            Console.WriteLine(" Markası: "+Marka + " şanzımantürü: "+ Sanzıman + "Modelyili :"+ _modelyili +"puanı: "+ _yildiz);
        }
       
    }
   
}

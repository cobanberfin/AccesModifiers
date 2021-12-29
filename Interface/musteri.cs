using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class musteri : Imusteri,IDeneme
    {   private int _id;
        public int Id { get { return _id; }set { _id = value; } }
        private string _Ad;
        public string isim { get { return _Ad; } set { _Ad = value; } }
        private string _Soyad;
        public string soyisim { get { return _Soyad; } set { _Soyad = value; } }

        public int denemeno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int kayitduzenle(int Id, string isim, string soyisim)
        {
            Console.WriteLine("kayıt duzenlendı");
            return 1;
        }

        public int yenikayıt(string isim, string soyisim)
        {
            Console.WriteLine("kayıt eklendı");
            return 1;
        }

        public int deneme()
        {
            throw new NotImplementedException();
        }
    }
}

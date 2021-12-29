using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class GenericRepository<T> where T:class
    {
        public GenericRepository()
        {
            //context:ef Dbfirst
        }

        public virtual List<T> Getir()
        {
            return null;
            //gelen t tipini database uzerınden sorgulamak ve elde etmıs oldugum kayıtları generıc olarak ust katmana dönustur
        }

        public virtual List<T> YeniKayıtEkle()
        {
            return null;
        }




    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.database;
using TodoList.entities;

namespace TodoList.BusinessServices
{
   public class KullanıcıService
    {
        public Kullanıcı kullanıcıkontrol (string kullaniciAdı,string sifre)
        {
            return SanalDatabase.kullanıcıTablo.Where(x => x.KullanıcıAdı == kullaniciAdı && x.Sifre == sifre).FirstOrDefault();
        }



    }
}

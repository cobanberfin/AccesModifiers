using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.entities;

namespace TodoList.database
{
   public static class SanalDatabase
    {



        public static List<Kullanıcı> kullanıcıTablo;
        public static List<todo> todoTablo;
        static SanalDatabase()
        {
            kullanıcıTablo = new List<Kullanıcı>();
            kullanıcıTablo.Add(new Kullanıcı
            {
                id = Guid.NewGuid(),
                KullanıcıAdı = "test1",
                Sifre = "1"


            }) ;
            todoTablo = new List<todo>();

        }
    }
}

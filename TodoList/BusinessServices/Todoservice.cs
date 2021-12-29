using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.database;
using TodoList.entities;

namespace TodoList.BusinessServices
{
    public class Todoservice
    {
        public int kayıtKontrol()
        {//sanaldakı todo tablonun sayısını yolla
            return SanalDatabase.todoTablo.Count;

        }
        //todotablosundakı elemanları gönder
        public List<todo> kayıtListe()
        {
            return SanalDatabase.todoTablo;
        }

        public int YeniKayıt(todo data)
        {
            try
            {
                SanalDatabase.todoTablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}


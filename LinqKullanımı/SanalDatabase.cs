using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqKullanımı
{

    public class SanalDatabase
    {
        List<Musteri> musteriler;

        public SanalDatabase()
        {
            musteriler = new List<Musteri>();
        }

        public List<Musteri> Musterilistesi()
        {
            for (int i = 0; i < 1000; i++)
            {
                Musteri m = new Musteri();

                m.MusteriNo = i;
                m.İsim = FakeData.NameData.GetFirstName();
                m.Soysim= FakeData.NameData.GetSurname();
                m.İl = FakeData.PlaceData.GetCity();
                m.İlçe = FakeData.PlaceData.GetStreetName();

                m.Ulke = FakeData.PlaceData.GetCountry();
                m.Dogumtarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1990, 01, 01), new DateTime(1999, 01, 01));
                m.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                m.email = $"{m.İsim.ToLower()}.{m.Soysim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                musteriler.Add(m);



            }
            return musteriler;


        }




    }


}

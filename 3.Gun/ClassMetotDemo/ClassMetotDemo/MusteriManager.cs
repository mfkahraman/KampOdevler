using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Adı : " + musteri.Name + " Soyadı : " + musteri.Surname + " Kimlik Numarası : " + musteri.Id + " Telefon Numarası : " + musteri.Phone + 
                " Sayın müşterimiz, hesabınız bu bilgilerle başarılı şekilde oluşturulmuştur." );
        }
        
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri listesi oluşturuluyor..");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Adı : " + musteri.Name + " Soyadı : " + musteri.Surname + " Kimlik Numarası : " + musteri.Id + "Telefon Numarası : " + musteri.Phone);
            }
            Console.WriteLine("Müşteriler Listelendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sayın " + musteri.Name + " " + musteri.Surname + " Hesabınız başarıyla silinmiştir.");
        }
    }
}

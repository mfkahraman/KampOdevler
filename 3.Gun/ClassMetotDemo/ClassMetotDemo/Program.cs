namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Ayşe";
            musteri1.Surname = "Çelik";
            musteri1.Id = "2305689712";
            musteri1.Phone = "5445648972";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Ali";
            musteri2.Surname = "Akar";
            musteri2.Id = "2305689487";
            musteri2.Phone = "5445642397";

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Ahmet";
            musteri3.Surname = "Yılmaz";
            musteri3.Id = "5476212598";
            musteri3.Phone = "5325478923";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);


        }
    }
}
namespace ListeOlusturmaOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakaSehir = new MyDictionary<int, string>();
            plakaSehir.Add(47, "Mardin");
            plakaSehir.Add(34, "İstanbul");
            plakaSehir.Add(01, "Adana");
            plakaSehir.Add(26, "Eskişehir");
            plakaSehir.Add(06, "Ankara");
            plakaSehir.Add(20, "Diyarbakır");
            plakaSehir.Add(65, "Van");
            plakaSehir.Add(07, "Antalya");

            plakaSehir.Listele();
        }
    }
}
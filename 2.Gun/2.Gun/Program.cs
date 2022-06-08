namespace _2.Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Samsung Telefon";
            product1.Description = "16gb ram, 128gb hafıza, Fullhd ekran";
            product1.Price = 5392;
            product1.Sold = 58;
            product1.Left = 73;

            Product product2 = new Product();
            product2.Name = "Phillips Traş Makinesi";
            product2.Description = "8 parça traş seti";
            product2.Price = 1495;
            product2.Sold = 148;
            product2.Left = 157;

            Product product3 = new Product();
            product3.Name = "Arçelik Elektrikli Süpürge";
            product3.Description = "Çok amaçlı temizlik, koltuk ve halı yıkama özellikli";
            product3.Price = 3953;
            product3.Sold = 69;
            product3.Left = 21;

            Product product4 = new Product();
            product4.Name = "Monster Oyun Bilgisayarı";
            product4.Description = "FullHD ekran, 32gb Ram, i7 işlemci, Nvidia ekran kartı";
            product4.Price = 15627;
            product4.Sold = 25;
            product4.Left = 12;

            Product[] products = new Product[] { product1, product2, product3, product4};

            Console.WriteLine("For döngüsü başlıyor");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürünün Adı : " + products[i].Name);
                Console.WriteLine("Açıklaması: " + products[i].Description);
                Console.WriteLine("Fiyatı : " + products[i].Price);
                Console.WriteLine("Satılan Adet : " + products[i].Sold);
                Console.WriteLine("Stok Adedi : " + products[i].Left);
                Console.WriteLine("--------------------");
                                
            }
            Console.WriteLine("For döngüsü bitti. Foreach döngüsü başlıyor.");

            foreach (Product prd in products)
            {
                Console.WriteLine("Ürünün Adı : " + prd.Name);
                Console.WriteLine("Açıklaması: " + prd.Description);
                Console.WriteLine("Fiyatı : " + prd.Price);
                Console.WriteLine("Satılan Adet : " + prd.Sold);
                Console.WriteLine("Stok Adedi : " + prd.Left);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("Foreach döngüsü bitti. While döngüsü başlıyor.");

            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine("Ürünün Adı : " + products[j].Name);
                Console.WriteLine("Açıklaması: " + products[j].Description);
                Console.WriteLine("Fiyatı : " + products[j].Price);
                Console.WriteLine("Satılan Adet : " + products[j].Sold);
                Console.WriteLine("Stok Adedi : " + products[j].Left);
                Console.WriteLine("--------------------");

                j++;
            }

            Console.WriteLine("While Döngüsü Bitti.");
        }
    }
}
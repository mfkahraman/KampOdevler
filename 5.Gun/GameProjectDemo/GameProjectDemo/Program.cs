using GameProjectDemo.Entities;
using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;

Player serdar = new Player()
{ FirstName = "Serdar", LastName = "Kara", Id = 11, NationalityId = "52476529382", DateOfBirth = new DateOnly(1988, 3, 15) };
Player omer = new Player()
{ FirstName = "Ömer", LastName = "Kara", Id = 12, NationalityId = "52476524849", DateOfBirth = new DateOnly(1997, 10, 22) };
Player hasan = new Player()
{ FirstName = "Hasan", LastName = "Çelik", Id = 13, NationalityId = "3982456741", DateOfBirth = new DateOnly(1992, 5, 29) };

Game fm = new Game() { Id = 21, Name = "Football Manager 2022", Description = "Futbol menajerliği simülasyonu", Price = 480 };
Game etw = new Game() { Id = 22, Name = "Empire Total War", Description = "Tarihi strateji oyunu", Price = 257 };
Game dota = new Game() { Id = 23, Name = "DOTA 2", Description = "Defence of the ancients", Price = 341 };

Campaign yaz = new Campaign() { Id = 31, Name = "Yaz Kampanyası", Description = "Yaza özel harika indirimler!", DiscountRate = 20 };
Campaign kis = new Campaign() { Id = 32, Name = "Kış Kampanyası", Description = "Soğuk günlerde oyun oynamak iyi gider", DiscountRate = 15 };
Campaign bahar = new Campaign() { Id = 33, Name = "Bahar Kampanyası", Description = "Oyun sezonu başlasın!", DiscountRate = 18 };

BasePlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
ICampaignService campaignManager = new CampaingManager();
ISaleService saleManager = new SaleManager();


Console.WriteLine("OYUNCU İŞLEMLERİ");
Console.WriteLine("Oyuncu kayıt İşlemleri;");
Console.WriteLine("\n");
playerManager.Register(serdar);
Console.WriteLine("\n");
playerManager.Register(omer);
Console.WriteLine("\n");
playerManager.Register(hasan);
Console.WriteLine("\n");
Console.WriteLine("Oyuncu bilgileri güncelleme işlemi;");
playerManager.Update(omer);
Console.WriteLine("\n");
Console.WriteLine("Oyuncu hesabı silme işlemi;");
playerManager.DeleteAccount(serdar);
Console.WriteLine("\n");
Console.WriteLine("\n");


Console.WriteLine("KAMPANYA İŞLEMLERİ");
Console.WriteLine("Kampanya ekleme işlemleri;");
Console.WriteLine("\n");
campaignManager.Add(yaz);
Console.WriteLine("\n");
campaignManager.Add(kis);
Console.WriteLine("\n");
campaignManager.Add(bahar);
Console.WriteLine("\n");
Console.WriteLine("Kampanya güncelleme işlemi;");
campaignManager.Update(kis);
Console.WriteLine("\n");
Console.WriteLine("Kampanya silme işlemi;");
campaignManager.Delete(bahar);
Console.WriteLine("\n");
Console.WriteLine("\n");


Console.WriteLine("OYUN SATIŞI İŞLEMLERİ");
Console.WriteLine("İndirimsiz oyun satışı işlemleri;");
Console.WriteLine("\n");
saleManager.Sale(fm, omer);
Console.WriteLine("\n");
saleManager.Sale(dota, hasan);
Console.WriteLine("\n");
saleManager.Sale(etw, serdar);
Console.WriteLine("\n");
Console.WriteLine("İndirimli Oyun satışı işlemleri");
saleManager.DiscountSale(fm, omer,yaz);
Console.WriteLine("\n");
saleManager.DiscountSale(dota, hasan,bahar);
Console.WriteLine("\n");
saleManager.DiscountSale(etw, serdar,kis);
Console.WriteLine("\n");
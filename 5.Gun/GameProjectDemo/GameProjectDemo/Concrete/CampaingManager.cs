using System;
using GameProjectDemo.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarıyla eklenmiştir. Kampanya bilgileri şu şekildedir;");
            Console.WriteLine("Kampanya Adı: "+campaign.Name+ " Kampanya Numarası: "+campaign.Id+" İndirim Oranı: %"+campaign.DiscountRate);
            Console.WriteLine("Kampanya Açıklaması: " + campaign.Description);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Id+" numaralı "+campaign.Name+" adlı kampanya başarıyla silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " numaralı " + campaign.Name + " adlı kampanyanın bilgileri başarıyla güncellenmiştir.");
        }
    }
}

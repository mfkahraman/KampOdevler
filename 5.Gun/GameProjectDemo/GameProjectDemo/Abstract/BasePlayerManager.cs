using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public void DeleteAccount(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " isimli kullanıcının hesabı başarıyla silinmiştir.");
        }

        public virtual void Register(Player player)
        {
            Console.WriteLine("T.C. Kimlik Numarası: "+player.NationalityId+" "+"Doğum tarihi: "+player.DateOfBirth+" olan " + "\n" 
                + player.FirstName + " " + player.LastName + " isimli kullanıcının hesabı başarıyla oluşturulmuştur."+ "\n"
                + "Sistem kullanıcı  numarası: " + player.Id+" olarak belirlenmiştir.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " isimli kullanıcının bilgileri başarıyla güncellenmiştir.");
        }
    }
}

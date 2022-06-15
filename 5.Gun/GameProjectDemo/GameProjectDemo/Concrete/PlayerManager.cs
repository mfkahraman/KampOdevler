using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Register(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player)==true)
            {
               base.Register(player);
            }
            else
            {
                Console.WriteLine(player.FirstName+ " "+player.LastName+" isimli kullanıcının bilgileri doğrulanamadı.");
            }
            
        }
    }
}

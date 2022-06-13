using System;
using GameProjectDemo.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            if (player.NationalityId.Length==11 )
            {
               return true;
            }
            else
            {
               return false;
            }
        }
    }
}

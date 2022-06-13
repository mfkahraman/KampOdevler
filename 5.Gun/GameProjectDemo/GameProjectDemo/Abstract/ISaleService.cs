using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        void DiscountSale(Game game, Player player, Campaign campaign);

        void Sale(Game game, Player player);
    }
}

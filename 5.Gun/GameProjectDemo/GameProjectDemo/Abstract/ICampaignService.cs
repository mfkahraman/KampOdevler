using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaing);
        void Update(Campaign campaing);
        void Delete(Campaign campaing);
    }
}

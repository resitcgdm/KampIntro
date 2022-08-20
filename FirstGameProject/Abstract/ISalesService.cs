using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Abstract
{
    public interface ISalesService
    {
        void SaleWithCampaign(Game game, Gamer gamer, Campaign campaign);
        void JustSale(Game game, Gamer gamer);
    }
}

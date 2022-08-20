using FirstGameProject.Abstract;
using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void JustSale(Game game, Gamer gamer)
        {
            Console.WriteLine("The Name of Game: "+game.GameName);
            Console.WriteLine("The Category of Game: "+game.GameCategory);
            Console.WriteLine("The Price of Game: " + game.GamePrice);

        }

        public void SaleWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            if (game.Id%2 ==0)
            {   
                Console.WriteLine("This game has a %20 discount");
              //  var a = game.GamePrice;
               // a = a / 5;

            }
            else
            {
                Console.WriteLine("Has no discount");
            }
        }
    }
}

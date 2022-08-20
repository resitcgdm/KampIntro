using FirstGameProject.Abstract;
using FirstGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        List<Campaign> campaignes = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaignes.Add(campaign);
            Console.WriteLine(campaign.CampaignName+"will be added successfully "+" ");
        }

        public void Delete(Campaign campaign)
        {
            campaignes.Remove(campaign);
            Console.WriteLine(campaign.CampaignName +"-"+ "will be deleted successfully");
            
        }

        public void List()
        {
            foreach (var cmpign in campaignes)
            {
                Console.WriteLine(cmpign.CampaignName+cmpign.CampainDiscount);
                Console.WriteLine("The Campaignes will be listed successfully");
            }
            
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Entry campaign name which campaign you want to update");
            campaign.CampaignName = Console.ReadLine();
            Console.WriteLine("will be updated successfully");
        }
    }
}

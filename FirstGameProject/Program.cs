// See https://aka.ms/new-console-template for more information


using FirstGameProject.Abstract;
using FirstGameProject.Adapters;
using FirstGameProject.Concrete;
using FirstGameProject.Entities;

Campaign campaign1= new Campaign();
campaign1.Id = 1;
campaign1.CampaignName = "%20 indirim var geeel";
campaign1.CampainDiscount = 20;

CampaignManager campaignManager=new CampaignManager();
campaignManager.Add(campaign1);
Console.WriteLine(campaign1);


BaseManager gamerManager = new GamerManager(new MernisServiceAdapter());
gamerManager.Add(new Gamer
{
    DateOfBirth = new DateTime(1996, 8, 6),
    FirstName = "Reşit Çiğdem",
    LastName = "Doğan",
    NationalityId = "49189066384",
    Id = 2
});


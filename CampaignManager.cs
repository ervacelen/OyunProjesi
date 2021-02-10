using OyunProjesi.Concrete;
using OyunProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi.Manager 
{
    class CampaignManager : ICampaignService
    {
        List<ICampaign> campaigns = new List<ICampaign>();
        public void Add(ICampaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Campaign added to db:" + campaign.Name + campaign.Discount);
            
        }

        public void ApplyDiscount(Game game, ICampaign campaign)
        {
            var _discount = campaign.Discount;
            var _gamePrice = game.Price;
            var newGamePrice = _gamePrice * (100 - _discount) / 100;

            game.Price = newGamePrice;
            Console.WriteLine("Campaign price of " + game.Name + "is " + game.Price + "$" + "with" + campaign.Name);
            
        }

        public void DisplayDiscount(ICampaign campaign)
        {
            Console.WriteLine("Discount rate of campaign is " + "   " + campaign.Name + "   " + campaign.Discount);
            
        }

        public void List()
        {
            Console.WriteLine("\n ---------------All Campaigns---------------");
            Console.WriteLine("Name " + "\t\t Discount Rate(%)");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.Name + "\t " + campaign.Discount);
            }
            Console.WriteLine("\n");


        }

        public void Remove(ICampaign campaign)
        {
            campaigns.Remove(campaign);

        }
    }
}

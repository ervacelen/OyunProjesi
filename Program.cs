using OyunProjesi.Concrete;
using OyunProjesi.Manager;
using System;


namespace OyunProjesi
{
    class Program
    {
        public static int Id { get; private set; }
        public static string Name { get; private set; }
        public static int Discount { get; private set; }

        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, Name = "The Sims", Price = 150 };
            Game game2 = new Game() { Id = 2, Name = "Counter Strike", Price = 100 };
            Game game3 = new Game() { Id = 3, Name = "GTA", Price = 200 };
            Game game3_update = new Game() { Id = 3, Name = "GTA 2020", Price = 200 };

            GameManager gameManager = new GameManager();


            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);
            gameManager.List();
            gameManager.Remove(game2);
            gameManager.Update(3, game3_update);

            gameManager.List();

            ICampaign campaign1 = new Campaign() { Id = 1, Name = "New Year", Discount = 40 };
            ICampaign campaign2 = new Campaign() { Id = 2, Name = "Weekly Discount", Discount = 25 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            campaignManager.List();

            campaignManager.ApplyDiscount(game1, campaign1);
            campaignManager.ApplyDiscount(game3, campaign2);

            gameManager.List();


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1993, FirstName = "Erva", IdentityNumber = 123456 });
        }
    }
}

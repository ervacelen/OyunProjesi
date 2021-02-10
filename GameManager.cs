using OyunProjesi.Concrete;
using OyunProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProjesi.Manager
{
    class GameManager : IGameService
    {
        List<Game> gameList = new List<Game>();
        public void Add(Game game)
        {
            gameList.Add(game);
            Console.WriteLine("Game added to db: " + game.Name);

        }

        public void List()
        {
            Console.WriteLine("----------------All Games----------------");
            Console.WriteLine("Name \t\t Price ($)");

            foreach (var game in gameList)
            {
                Console.WriteLine(game.Name + " \t" + game.Price);
            }
            Console.WriteLine("\n");

        }

        public void Remove(Game game)
        {
            gameList.Remove(game);
            Console.WriteLine("Game removed from db: " + game.Name);

        }

        public void Update(int Id, Game game)
        {
            foreach (var _game in gameList)
            {
                _game.Name = _game.Id == Id ? game.Name : _game.Name;
                _game.Price = _game.Id == Id ? game.Price : _game.Price;
            }

            Console.WriteLine("Game is updated as: " + game.Name);
            Console.WriteLine("\n");

            Console.WriteLine("Name" + " \t\t  Price($)");
            Console.WriteLine(game.Name + "          " + game.Price);

        }
    }
}

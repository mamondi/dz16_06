using System;
using Game_Data;
using Game_Models; // чомусь не можу додати референс до проекту

namespace ADO_NET_7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new GameContext())
            {
                var game1 = new Game
                {
                    Name = "GTA V",
                    Studio = "Rockstar Games",
                    Style = "Action",
                    ReleaseDate = new DateTime(2013, 9, 17)
                };
                var game2 = new Game
                {
                    Name = "Cyberpunk 2077",
                    Studio = "CD Projekt Red",
                    Style = "Action",
                    ReleaseDate = new DateTime(2020, 12, 10)
                };
                var game2 = new Game
                {
                    Name = "The Witcher 3: Wild Hunt",
                    Studio = "CD Projekt Red",
                    Style = "Action",
                    ReleaseDate = new DateTime(2015, 5, 19)
                };

                context.Games.AddRange(game1, game2);
                context.SaveChanges();

                foreach (var game in context.Games)
                {
                    Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Style: {game.Style}, Release Date: {game.ReleaseDate}");
                }
            }
        }
    }
}
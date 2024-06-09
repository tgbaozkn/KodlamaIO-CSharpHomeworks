using System;
using GameSystem.Entities;

namespace GameSystem.Controllers.AboutGame
{
    public class GameManager : IGameManager

    {
        public GameManager(List<Game> games)
        {
            Console.WriteLine("");
            Console.WriteLine("İşte sistemdeki oyunlar :".ToUpper());

            foreach(var game in games)
            {
                Console.WriteLine("");
                Console.WriteLine(game.Name +" - " +game.Price + "TL");
         
            }
           
        }


        public void Buy(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + "adlı oyuncu bu oyunu almak istiyor : ");
            Console.WriteLine(game.Name + " - " + game.Price + "TL");
            Console.WriteLine("Fiyat hesaplanırken lütfen bekleyin...");

            game.Price = game.Price * campaign.Rate;
            Console.WriteLine(campaign.Name +" " + " kampanyası sonrası alınmak istenen" + " "+ game.Name+ " " + " oyununun son fiyatı:");
            Console.WriteLine(game.Price +" "+ "TL");
            Console.WriteLine(gamer.FirstName.ToUpper()+ " " +gamer.LastName.ToUpper() +" " + game.Name.ToUpper() + "  OYUNU BAŞARIYLA SATIN ALINDI");
            

        }
    }
}


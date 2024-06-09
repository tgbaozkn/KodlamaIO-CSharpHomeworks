using GameSystem.Adapters;
using GameSystem.Controllers;
using GameSystem.Controllers.AboutGame;
using GameSystem.Entities;

class Program
{
    static void Main()
    {
        //games
        Game game1 = new Game { Id = 1, Name = "GTA", Price = 1059.99 };
        Game game2 = new Game { Id = 2, Name = "Ninja", Price = 699.98 };
        Game game3 = new Game { Id = 3, Name = "Sims", Price = 2059.99 };
        Game game4 = new Game { Id = 4, Name = "Run", Price = 341.99 };
        List<Game> games = new List<Game> { game1,game2,game3,game4}; 
        GameManager gameManager = new GameManager (games);

        //campaigns
        Campaign campaign1 = new Campaign { Id = 1, Name = "Ogrenci İndirimi Yarı yarıya", Rate = 0.5 };
        Campaign campaign2 = new Campaign { Id = 2, Name = "Yüzde Yirmi İndirimli", Rate = 0.8 };
        List<Campaign> campaigns = new List<Campaign> { campaign1, campaign2 };
        CampaignManager campaignManager = new CampaignManager(campaigns);
        //gamers

        Gamer gamer1 = new Gamer { Id = 1, FirstName = "Tuğba", LastName = "Özkan", BirthYear = "2000", NationallyId = 1233 };
        Gamer gamer2 = new Gamer { Id = 2, FirstName = "Reyyan", LastName = "Özkan", BirthYear = "2006", NationallyId = 123 };
        List<Gamer> gamers = new List<Gamer> {};

        GamerManager gamerManager = new GamerManager(new MernisService());
        gamerManager.Save(gamer1);
        //gamerManager.Save(gamer2);
        //gamerManager.Delete(gamer1);
        //gamerManager.Save(gamer1);
        //gamerManager.Update(gamer1);
        var campaign = campaignManager.ChooseCampaign(campaigns);
        gameManager.Buy(game2, gamer1, campaign);
       
        


    }

}
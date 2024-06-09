using System;
using GameSystem.Entities;

namespace GameSystem.Controllers.AboutGame
{
	public class CampaignManager
	{
		


        public CampaignManager(List<Campaign> campaigns)
		{
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("İşte aktif tüm kampanyalar: ".ToUpper()  );
			foreach(var campaign in campaigns)
			{
				Console.WriteLine("");
				Console.WriteLine(campaign.Id+ "-" +campaign.Name);
              


            }
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public Campaign ChooseCampaign(List<Campaign> campaigns)
        {
            Console.WriteLine("Listeden seçmek istediğiniz kampanyanın numarasını yazın:");

            var campaignID = Console.ReadLine();

         
            if (int.TryParse(campaignID, out int parsedCampaignID))
            {
               
                var campaign = campaigns.Find(c => c.Id == parsedCampaignID);
                if (campaign != null)
                {
                    Console.WriteLine("Kampanya uygulanıyor: " + campaign.Name);
                    return campaign;
                }
                else
                {
                    Console.WriteLine("Geçerli bir kampanya bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir numara girmediniz.");
            }

            return null;
        }



        List<Campaign> campaigns = new List<Campaign>();
   
       
        public  void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine(campaign.Name +" " + "kampanyası silindi.");
          
        }

    }
}


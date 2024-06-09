using System;
using GameSystem.Entities;
namespace GameSystem.Controllers.AboutGame
{
	public interface IGameManager
	{
		void Buy(Game game,Gamer gamer, Campaign campaign);
		
	}
}


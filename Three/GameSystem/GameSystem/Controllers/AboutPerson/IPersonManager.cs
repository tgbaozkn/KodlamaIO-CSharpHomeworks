using System;
using GameSystem.Entities;

namespace GameSystem.Controllers
{
	public interface IPersonManager
	{
		void Save(Person person);
		void Update(Person oldperson);
		void Delete(Person person);
    }
}


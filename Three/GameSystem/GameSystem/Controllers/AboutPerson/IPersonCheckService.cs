using System;
using GameSystem.Entities;

namespace GameSystem.Controllers
{
	public interface IPersonCheckService
	{
        bool CheckIfRealPerson(Person person);
    }
}


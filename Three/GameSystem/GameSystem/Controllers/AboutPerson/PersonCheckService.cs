using System;
using GameSystem.Entities;

namespace GameSystem.Controllers
{
    public class PersonCheckService : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}


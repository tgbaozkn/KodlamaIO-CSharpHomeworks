using System;
using GameSystem.Entities;

namespace GameSystem.Controllers
{
    public abstract class BasePersonManager : IPersonManager
    {
        public virtual void Delete(Person person)
        {
            Console.WriteLine("Deleted from the list : " + person.FirstName + person.LastName);
        }

        public virtual void Save(Person person)
        {
            Console.WriteLine("saved to the list : " + person.FirstName);
        }

        public virtual void Update(Person oldperson)
        {
            Console.WriteLine("updated this : " + oldperson.FirstName + " " + oldperson.LastName + " " + oldperson.BirthYear + " " + oldperson.NationallyId);
        }
    }
}


using System;
using GameSystem.Entities;

namespace GameSystem.Controllers
{
    public class GamerManager : BasePersonManager
    {
        List<Person> personsOnSystem = new List<Person>();
        private IPersonCheckService _personCheckService;
        public GamerManager(IPersonCheckService personCheckService) {
            _personCheckService = personCheckService;
        }
        public override void Delete(Person personfordelete)
        {
            personsOnSystem.Remove(personfordelete);
            base.Delete(personfordelete);
        }

        public override void Save(Person person)
        {

            if (_personCheckService.CheckIfRealPerson(person))
            {
                var existperson= personsOnSystem.Find(p => p.NationallyId == person.NationallyId);
                if(existperson == null)
                {
                    base.Save(person);
                    personsOnSystem.Add(person);
                    Console.WriteLine("Son durumdaki kullanıcılar:" );
                    foreach(var p in personsOnSystem)
                    {
                        Console.WriteLine(p.FirstName + p.LastName);
                    }
                }
                else
                {
                    Console.WriteLine("Bu kullanıcı zaten var.");
                }
               
            }
            else
            {
                Console.WriteLine("Invalid person identity.");
            }
        }

        public override void Update(Person oldperson)
        {
            Console.WriteLine("Güncellemek istediğiniz kullanıcının ilk adını giriniz:");
            var name = Console.ReadLine();
            oldperson = personsOnSystem.Find(person => person.FirstName == name);
            if(oldperson !=null)
            {
                Console.WriteLine("Güncellemek istediğiniz yeni adınızı girin:");
                oldperson.FirstName = Console.ReadLine();
                Console.WriteLine("Güncellemek istediğiniz yeni soyadınızı girin:");
                oldperson.LastName = Console.ReadLine();

                Console.WriteLine("Güncellemek istediğiniz yeni doğum yılınızı girin:");
                oldperson.BirthYear = Console.ReadLine();

                Console.WriteLine("Güncellemek istediğiniz yeni tc no girin:");
                oldperson.NationallyId = long.Parse(Console.ReadLine());
                base.Update(oldperson);
            }
            else
            {
                Console.WriteLine ("Bu isim sistemde yok");
            }


        }
    }
}


using System;
namespace GameSystem.Entities
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string BirthYear { get; set; }
        public long NationallyId { get; set; }
    }
}


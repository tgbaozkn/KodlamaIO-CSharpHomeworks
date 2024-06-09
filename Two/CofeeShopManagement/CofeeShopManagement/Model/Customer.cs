using System;
namespace CofeeShopManagement.Model
{
    public abstract class Customer : IPerson
    {
        public required string FirstName { get; set; }
        public required string LastName { get  ; set  ; }
        public int Id { get  ; set  ; }
        public DateTime DateOfBirth { get  ; set  ; }
        public required long NationallyId { get; set; }

    }
}


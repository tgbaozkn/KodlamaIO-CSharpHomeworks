using System;
namespace GameSystem.Entities
{
	public interface IPerson
	{
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; set; }
        string BirthYear { get; set; }
        long NationallyId { get; set; }
    }
}


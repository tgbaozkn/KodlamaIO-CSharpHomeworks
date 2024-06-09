using System;
namespace CofeeShopManagement.Model
{
	public interface IPerson
	{
		string FirstName { get; set; }
		string LastName { get; set; }
		int Id { get; set; }
		DateTime DateOfBirth { get; set; }
	


    }
}


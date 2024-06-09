using System;
using CofeeShopManagement.Model;

namespace CofeeShopManagement.Contoller
{
	public interface ICustomerCheckService
	{
        bool CheckIfRealPerson(Customer customer);  
    }
}


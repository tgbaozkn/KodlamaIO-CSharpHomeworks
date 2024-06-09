using System;
using CofeeShopManagement.Model;

namespace CofeeShopManagement.Contoller
{
	public abstract class BaseCustomerManager:ICustomerManager
	{
		

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
      
    }
}


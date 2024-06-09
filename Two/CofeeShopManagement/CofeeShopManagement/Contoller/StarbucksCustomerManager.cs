using System;
using CofeeShopManagement.Model;

namespace CofeeShopManagement.Contoller
{
	public class StarbucksCustomerManager:BaseCustomerManager

       
	{
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager (ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;

        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Invalid person identity.");
            }
           
        }

      
    }
}


using System;
using ClassMetotDemo.Model;

namespace ClassMetotDemo.Controller
{
	public class CustomerManager
	{
		List<Customer> customers = new List<Customer>();
		public void AddCustomer(Customer customer)
		{
            customers.Add(customer);
		}
		public void GetCustomers()
		{
			if(customers.Count <1)
			{
				Console.WriteLine("Nothing is found. Please add customer");
			}
			else { 
			Console.WriteLine(customers.Count + "customers are found:" );

			foreach(var customer in customers)
			{
				Console.WriteLine("Name" + customer.CustomerName);
				Console.WriteLine("Age " +customer.CustomerAge);
				Console.WriteLine("Customer Number"+customer.CustomerNumber);
				Console.WriteLine();
            }
            }
        }
		public void DeleteCustomer(Customer customer)
		{
			customers.Remove(customer);
			Console.WriteLine("Delete this customer" + customer.CustomerName);
		}
        public void DeleteByCustomerID(int customerId)
        {
            var customerToDelete = customers.SingleOrDefault(r => r.CustomerId == customerId);

            if (customerToDelete != null)
            {
                customers.Remove(customerToDelete);
                Console.WriteLine("Deleted customer: " + customerToDelete.CustomerName);
            }
            else
            {
                Console.WriteLine("Customer with ID " + customerId + " not found.");
            }
        }
    }
}


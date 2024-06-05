// See https://aka.ms/new-console-template for more information

using ClassMetotDemo.Controller;
using ClassMetotDemo.Model;

class Program           
{
    static void Main()
    {
        CustomerManager customerManager = new CustomerManager();
      
        Customer customer1 = new Customer { CustomerAge = 23, CustomerName="Tugba", CustomerId = 1, CustomerNumber = "123" };
        Customer customer2 = new Customer { CustomerName="Ayşe", CustomerAge=24,CustomerNumber="2929",CustomerId=2};
        Customer customer3 = new Customer { CustomerName="Fatma", CustomerAge=24,CustomerNumber="2929",CustomerId=3};
        Customer customer4 = new Customer { CustomerName="Hayriye", CustomerAge=24,CustomerNumber="2929",CustomerId=4};
        Customer customer5 = new Customer { CustomerName="Mualla", CustomerAge=24,CustomerNumber="2929",CustomerId=5};
        List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4, customer5 };
        foreach(var customr in customers)
        {
            customerManager.AddCustomer(customr);
        }

        customerManager.GetCustomers();
        customerManager.DeleteByCustomerID(2);
        customerManager.GetCustomers();
        customerManager.DeleteCustomer(customer4);
        customerManager.GetCustomers();

    }

}
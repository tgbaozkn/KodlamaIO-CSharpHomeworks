// See https://aka.ms/new-console-template for more information
using CofeeShopManagement.Contoller;
using CofeeShopManagement.Model;
using CofeeShopManagement.Adapters;
class Program
{
    static void Main(string[] args)
    {
        //BaseCustomerManager neroCustomerManager = new NeroCustomerManager();
        //neroCustomerManager.Save(new StarbucksCustomer
        //{
        //    FirstName = "Tuğba",
        //    Id = 1,
        //    LastName = "Özkan",
        //    NationallyId =20,
        //    DateOfBirth = new DateTime(2000, 20, 20)
        //});

        BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
        StarbucksCustomer cutormer = new StarbucksCustomer
        {
            DateOfBirth = new DateTime(2000, 20, 20),
            FirstName = "Tuğba",
            LastName = "Özkan",
            NationallyId = 2000,
            Id = 2
        };
        starbucksCustomerManager.Save(cutormer);
  
     

    }
}


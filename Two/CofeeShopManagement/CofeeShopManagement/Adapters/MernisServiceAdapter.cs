using System;
using CofeeShopManagement.Contoller;
using CofeeShopManagement.Model;
using ServiceReference;

namespace CofeeShopManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService

    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return MernisCheck(customer).GetAwaiter().GetResult();
        }

        private async Task<bool> MernisCheck(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            int year = customer.DateOfBirth.Year;
            var response = await client.TCKimlikNoDogrulaAsync(customer.NationallyId, customer.FirstName.ToUpperInvariant(), customer.LastName.ToUpper(), year);
            return response.Body.TCKimlikNoDogrulaResult;
        }


    }
}


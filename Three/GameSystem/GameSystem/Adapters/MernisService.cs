using System;
using GameSystem.Controllers;
using GameSystem.Entities;
using ServiceReference;
namespace GameSystem.Adapters
{
    public class MernisService : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return MernisCheck(person).GetAwaiter().GetResult();
        }

        private async Task<bool> MernisCheck(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
         
            var response = await client.TCKimlikNoDogrulaAsync(person.NationallyId, person.FirstName.ToUpperInvariant(), person.LastName.ToUpper(), int.Parse(person.BirthYear));
            return response.Body.TCKimlikNoDogrulaResult;
        }
    }
}


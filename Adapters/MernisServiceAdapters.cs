using Starbucks_Nero_Coffe_Shop.Abstract;
using Starbucks_Nero_Coffe_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference1;
using System.Threading.Tasks;

namespace Starbucks_Nero_Coffe_Shop.Adapters
{
    class MernisServiceAdapters : ICustomerCheckService
    {
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
        }
        static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}

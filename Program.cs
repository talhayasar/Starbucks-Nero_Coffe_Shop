using Starbucks_Nero_Coffe_Shop.Abstract;
using Starbucks_Nero_Coffe_Shop.Adapters;
using Starbucks_Nero_Coffe_Shop.Concrete;
using Starbucks_Nero_Coffe_Shop.Entities;
using System;

namespace Starbucks_Nero_Coffe_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapters());
            //StarBucksCustomerManager'e ICustomerCheckService'i constructor olarak
            //verdiğimiz için yani aslında implemente ettiğimiz için girdi olarak
            //bizden bunu istiyor.Bu ICustomerCheckService yerine MernisServiceAdapter
            //yada fakesi olan CustomerCheckService classlarını veririz ve bu classlar
            //ICustomerCheckService'i implemente ediyorlar.Bu yüzden zaten
            //ICustomerCheckService parametresi yerine bunları verebiliyoruz.
            //İkisininde içinde CheckIfRealPerson metodunu yazdık.İçeriğe göre çalışıyor.
            Customer customer1 = new Customer() { FirstName = "M.T", LastName = "Y", 
                DateOfBirth = new DateTime(0000,00,00), NationalId = "...." };
            customerManager.Save(customer1);
        }
    }
}

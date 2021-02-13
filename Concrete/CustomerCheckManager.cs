using Starbucks_Nero_Coffe_Shop.Abstract;
using Starbucks_Nero_Coffe_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks_Nero_Coffe_Shop.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {//burada ıcustomercheckservice interfacesinde imzası verilen metodun gövdesini burada
     // yazmış oluyoruz.StarbuckscustomerManager dosyasında if statement da ıcustomercheckservice
     //interfacesinden CheckIfRealPerson metodunu çağırıyoruz ama anlaşılan burada yazdığımız
     //gövde orada çalışıyor. Ozaman bir interfacenin bir metodunu bir classta gövde yazarak
     //tanımlıyoruz.Bence imkansız.Starbucks'ta bu classdan bu metodu almalıydı.
     //çünkü zaten interfacedeki olay bu. Sadece imza konur implemente edenler kullanır.
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

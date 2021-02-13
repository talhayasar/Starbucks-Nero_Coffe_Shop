using Starbucks_Nero_Coffe_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks_Nero_Coffe_Shop.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

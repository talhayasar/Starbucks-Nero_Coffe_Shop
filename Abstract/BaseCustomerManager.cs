using Starbucks_Nero_Coffe_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks_Nero_Coffe_Shop.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)//virtuality provide us overriding at starbucks 
        {
            Console.WriteLine("Saved to Database:" + customer.FirstName);
        }
    }
}

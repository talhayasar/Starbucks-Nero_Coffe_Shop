using Starbucks_Nero_Coffe_Shop.Abstract;
using Starbucks_Nero_Coffe_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starbucks_Nero_Coffe_Shop.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);//that's the code which save to database.Before this, control
                                    //whether real person or not.
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }

        }
    }
}

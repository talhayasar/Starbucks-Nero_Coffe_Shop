using Starbucks_Nero_Coffe_Shop.Abstract;
using System;

namespace Starbucks_Nero_Coffe_Shop.Entities
{
    public class Customer : IEntity//If not taking any implementations or inheritance, there will be a lack of objectivity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalId { get; set; }
    }
}

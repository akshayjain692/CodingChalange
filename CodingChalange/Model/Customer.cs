using CodingChalange.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChalange.Model
{
   public  class Customer 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsGoldCustomer { get; set; }
    }
}

using CodingChalange.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChalange.Interfaces
{
    public interface IXmlReader
    {
        Customer GetCustomerFromUserId(string userName, string password);
    }
}

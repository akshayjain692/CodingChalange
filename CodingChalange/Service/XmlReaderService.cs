using CodingChalange.Constants;
using CodingChalange.Interfaces;
using CodingChalange.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodingChalange.Service
{
    public class XmlReaderService : IXmlReader
    {
        public Customer GetCustomerFromUserId(string userName, string password)
        {
            var assembly = this.GetType().Assembly;
            var stream = assembly.GetManifestResourceStream(AppConstants.XmlFilePath);
            XDocument doc = XDocument.Load(stream);
            var _customer = doc.Descendants(AppConstants.ParentTag).Where(x => x.Attribute("UserName").Value.Equals(userName) && x.Attribute("Password").Value.Equals(password))?.Select(y =>
            new Customer
            {
                UserName = y.Attribute("UserName").Value,
                Password = y.Attribute("Password").Value,
                IsGoldCustomer = Convert.ToBoolean(y.Attribute("IsGoldCustomer").Value)
            });
            return _customer?.FirstOrDefault();
            //var c = from s in doc.Descendants("Customer") where s.Attribute("Username").Value.Equals(userName) select new Customer;
        }

       
    }
}

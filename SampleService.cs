using webxml.Models;
using System;

namespace webxml
{
    public class SampleService : ISampleService
    {
        public string Test(string s)
        {
            Console.WriteLine("Method executed");
            return s;
        }

        public void XmlMethod(System.Xml.Linq.XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }

        public User TestUser(User input)
        {
            return input;
        }
    }
}
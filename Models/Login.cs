using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace webxml.Models
{
    [DataContract]
    public class Login
    {
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string Password { get; set; }
    }
}
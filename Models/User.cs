using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace webxml.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string Email { get; set; }
    }
}
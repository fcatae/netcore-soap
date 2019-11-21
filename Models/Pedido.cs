using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace webxml.Models
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }        
        
        [DataMember]
        public string Status { get; set; }
        
        //[DataMember]
        //public decimal TotalPrice { get; set; }
    }
}
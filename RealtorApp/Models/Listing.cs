using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorApp.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public double Price { get; set; }
        public string StringPrice { get => Price.ToString("C0"); }
        public string Image { get; set; }
        public Details Details { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class Address
    {
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AreaCode { get; set; }
    }

    public class Details
    {
        public int Bed { get; set; }
        public double Bath { get; set; }
        public int Sqft { get; set; }
        public string StringSQFT { get => Sqft.ToString("N0"); }
    }
}

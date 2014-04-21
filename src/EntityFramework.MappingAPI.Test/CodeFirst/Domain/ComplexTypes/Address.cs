﻿using System.Data.Entity.Spatial;

namespace EntityFramework.MappingAPI.Test.CodeFirst.Domain.ComplexTypes
{
    public class Address
    {
        public string Country { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StreetAddress { get; set; }

        public DbGeography Location { get; set; }
    }
}
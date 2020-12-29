using System;
using System.Collections.Generic;

namespace CustomerVisitPlan.Model
{
    public class City
    {
        public City()
        {
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Region> Regions { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}

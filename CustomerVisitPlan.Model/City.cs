using System;
using System.Collections.Generic;

namespace CustomerVisitPlan.Model
{
    public class City:BaseEntity
    {
        public City()
        {
        }
        public string Name { get; set; }
        public ICollection<Region> Regions { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}

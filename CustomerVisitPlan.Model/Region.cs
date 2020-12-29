using System;
using System.Collections.Generic;

namespace CustomerVisitPlan.Model
{
    public class Region:BaseEntity
    {
        public Region()
        {
        }
        public string Name { get; set; }
        public string CityId { get; set; }
        public City City { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CustomerVisitPlan.Model
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }
        public DateTime? FoundationDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string CityId { get; set; }
        public City City { get; set; }
        public string RegionId { get; set; }
        public Region Region { get; set; }

        public ICollection<VisitPlan> VisitPlans { get; set; }
    }
}

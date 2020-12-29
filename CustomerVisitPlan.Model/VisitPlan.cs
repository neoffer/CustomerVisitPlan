using System;
namespace CustomerVisitPlan.Model
{
    public class VisitPlan:BaseEntity
    {
        public VisitPlan()
        {
        }
        public DateTime VisitDate { get; set; }
        public string Description { get; set; }
        public bool NotifyByEmail { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

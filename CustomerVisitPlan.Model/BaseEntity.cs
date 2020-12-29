using System;
namespace CustomerVisitPlan.Model
{
    public class BaseEntity
    {
        public BaseEntity()
        {
        }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

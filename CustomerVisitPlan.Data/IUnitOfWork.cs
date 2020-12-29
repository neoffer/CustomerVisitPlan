using System;
using System.Threading.Tasks;

namespace CustomerVisitPlan.Data
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}

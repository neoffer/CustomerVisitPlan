using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public interface IRegionService
    {
        Task<Region> Get(string id);
        Task<IList<Region>> GetAll();

        Task<bool> Insert(Region entity);
        Task<bool> Update(Region entity);
        Task<bool> Delete(string id);
    }

}

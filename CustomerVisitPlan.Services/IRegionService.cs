using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public interface ICityService
    {
        Task<City> Get(string id);
        Task<IList<City>> GetAll();

        Task<bool> Insert(City entity);
        Task<bool> Update(City entity);
        Task<bool> Delete(string id);
    }

}

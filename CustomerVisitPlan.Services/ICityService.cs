using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public interface ICustomerService
    {
        Task<Customer> Get(string id);
        Task<IList<Customer>> GetAll();

        Task<bool> Insert(Customer entity);
        Task<bool> Update(Customer entity);
        Task<bool> Delete(string id);
    }

}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Data;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customer> customerRepository;
        private readonly IUnitOfWork unitOfWork;
        public CustomerService(IRepository<Customer> customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Delete(string id)
        {
            try
            {
                await customerRepository.Delete(id);
                await unitOfWork.SaveChangesAsync();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        public Task<Customer> Get(string id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

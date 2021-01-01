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

        public async Task<Customer> Get(string id)
        {
            return await customerRepository.Get(id);
        }

        public async Task<IList<Customer>> GetAll()
        {
            return await customerRepository.GetAll();
        }

        public async Task<bool> Insert(Customer entity)
        {
            try
            {
                customerRepository.Insert(entity);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(Customer entity)
        {
            try
            {
                customerRepository.Update(entity);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

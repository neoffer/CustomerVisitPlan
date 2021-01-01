using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Data;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> cityRepository;
        private readonly IUnitOfWork unitOfWork;
        public CityService(IRepository<City> cityRepository, IUnitOfWork unitOfWork)
        {
            this.cityRepository = cityRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Delete(string id)
        {
            try
            {
                await cityRepository.Delete(id);
                await unitOfWork.SaveChangesAsync();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<City> Get(string id)
        {
            return await cityRepository.Get(id);
        }

        public async Task<IList<City>> GetAll()
        {
            return await cityRepository.GetAll();
        }

        public async Task<bool> Insert(City entity)
        {
            try
            {
                cityRepository.Insert(entity);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(City entity)
        {
            try
            {
                cityRepository.Update(entity);
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

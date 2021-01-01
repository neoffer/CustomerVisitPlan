using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Data;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public class RegionService : IRegionService
    {
        private readonly IRepository<Region> regionRepository;
        private readonly IUnitOfWork unitOfWork;
        public RegionService(IRepository<Region> regionRepository, IUnitOfWork unitOfWork)
        {
            this.regionRepository = regionRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Delete(string id)
        {
            try
            {
                await regionRepository.Delete(id);
                await unitOfWork.SaveChangesAsync();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<Region> Get(string id)
        {
            return await regionRepository.Get(id);
        }

        public async Task<IList<Region>> GetAll()
        {
            return await regionRepository.GetAll();
        }

        public async Task<bool> Insert(Region entity)
        {
            try
            {
                regionRepository.Insert(entity);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(Region entity)
        {
            try
            {
                regionRepository.Update(entity);
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

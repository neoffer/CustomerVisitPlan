using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Data;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Services
{
    public class VisitPlanService : IVisitPlanService
    {
        private readonly IRepository<VisitPlan> visitPlanRepository;
        private readonly IUnitOfWork unitOfWork;
        public VisitPlanService(IRepository<VisitPlan> visitPlanRepository, IUnitOfWork unitOfWork)
        {
            this.visitPlanRepository = visitPlanRepository;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Delete(string id)
        {
            try
            {
                await visitPlanRepository.Delete(id);
                await unitOfWork.SaveChangesAsync();
            } catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<VisitPlan> Get(string id)
        {
            return await visitPlanRepository.Get(id);
        }

        public async Task<IList<VisitPlan>> GetAll()
        {
            return await visitPlanRepository.GetAll();
        }

        public async Task<bool> Insert(VisitPlan entity)
        {
            try
            {
                visitPlanRepository.Insert(entity);
                await unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Update(VisitPlan entity)
        {
            try
            {
                visitPlanRepository.Update(entity);
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

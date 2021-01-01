using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerVisitPlan.Model;

namespace CustomerVisitPlan.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> Get(string id);
        Task<IList<T>> GetAll();

        void Insert(T entity);
        void Update(T entity);
        Task Delete(string id);
    }
}

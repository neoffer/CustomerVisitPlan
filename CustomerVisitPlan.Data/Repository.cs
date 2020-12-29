using System;
using System.Linq;
using System.Threading.Tasks;
using CustomerVisitPlan.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerVisitPlan.Data
{
    public class Repository<T> : IRepository<T> where T:BaseEntity
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> entities;
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        public async Task Delete(string id)
        {
            var entity = await this.Get(id);
            this.entities.Remove(entity);
        }

        public async Task<T> Get(string id)
        {
            return await entities.FirstOrDefaultAsync<T>(f => f.Id == id);
        }

        public async Task<System.Collections.Generic.IList<T>> GetAll()
        {
            return await entities.OrderByDescending(o => o.CreatedAt).ToListAsync();
        }

        public void Insert(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            entities.Update(entity);
        }
    }
}

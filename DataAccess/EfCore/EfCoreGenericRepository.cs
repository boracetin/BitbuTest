using Domain.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfCore
{
    public class EfCoreGenericRepository<TEntity,TContext>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public async Task<TEntity> Create(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(t);
                await context.SaveChangesAsync();
                return t;
            }
        }

        public async Task Delete(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(t);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<TEntity> GetElemanById(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<TEntity> Update(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Entry(t).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return t;
            }
        }
    }
}

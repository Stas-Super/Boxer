using Boxer.DAL.EF;
using Boxer.DAL.Entities;
using Boxer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.DAL.Interfaces
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected ApplicationDBContext ctx;
        public BaseRepository()
        {
            ctx = new ApplicationDBContext();
        }

        public  DbSet<T> Set() => ctx.Set<T>();
        public async Task Create(T item)
        {
            Set().Add(item);
            await ctx.SaveChangesAsync();
        }

        public virtual async Task Delete(int id)
        {
          var srchItem = await Set().FirstOrDefaultAsync(item => (item as BaseEntity<int>).Id == id)
                .ConfigureAwait(true);
            Set().Remove(srchItem);
            await ctx.SaveChangesAsync();
        }

        public Task<T> Get(int id)
        {
           return Set().FirstOrDefaultAsync(item => (item as BaseEntity<int>).Id == id);
        }

        public async Task<List<T>> GetAll()
        {
            return await Set().ToListAsync();
        }

        public async Task<List<T>> GetAll(Func<T, bool> predicate)
        {
            return await Task.Run(() => Set().Where(predicate).ToList());
        }
    }
}

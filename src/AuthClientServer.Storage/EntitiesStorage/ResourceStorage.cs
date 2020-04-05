namespace AuthClientServer.Storage
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ResourceStorage : IResourceStorage
    {
        private DbContextOptions DbContextOptions { get; set; }
        public ResourceStorage(DbContextOptions dbContextOptions) => DbContextOptions = dbContextOptions;

        public virtual Resource Add(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Resource>().Add(entity).Entity;
            context.SaveChanges();
            return entity;
        }

        public async virtual Task<Resource> AddAsync(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            var result = await context.Set<Resource>().AddAsync(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public virtual void AddRange(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().AddRange(entities);
            context.SaveChanges();
        }

        public async virtual Task AddRangeAsync(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            await context.Set<Resource>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public virtual IEnumerable<Resource> GetAll()
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            return context.Set<Resource>().ToList();
        }

        public async virtual Task<IEnumerable<Resource>> GetAllAsync()
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            return await context.Set<Resource>().ToListAsync();
        }

        public virtual Resource Update(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Resource>().Update(entity).Entity;
            context.SaveChanges();
            return entity;
        }

        public async virtual Task<Resource> UpdateAsync(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Resource>().Update(entity).Entity;
            await context.SaveChangesAsync();
            return entity;
        }

        public virtual void UpdateRange(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().UpdateRange(entities);
            context.SaveChanges();
        }

        public async virtual Task UpdateRangeAsync(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().UpdateRange(entities);
            await context.SaveChangesAsync();
        }

        public virtual void Remove(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().Remove(entity);
            context.SaveChanges();
        }

        public async virtual Task RemoveAsync(Resource entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public virtual void RemoveRange(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().RemoveRange(entities);
            context.SaveChanges();
        }

        public async virtual Task RemoveRangeAsync(IEnumerable<Resource> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Resource>().RemoveRange(entities);
            await context.SaveChangesAsync();
        }
    }
}

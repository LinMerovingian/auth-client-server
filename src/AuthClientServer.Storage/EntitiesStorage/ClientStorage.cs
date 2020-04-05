namespace AuthClientServer.Storage
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ClientStorage : IClientStorage
    {
        private DbContextOptions DbContextOptions { get; set; }
        public ClientStorage(DbContextOptions dbContextOptions) => DbContextOptions = dbContextOptions;

        public virtual Client Add(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Client>().Add(entity).Entity;
            context.SaveChanges();
            return entity;
        }

        public async virtual Task<Client> AddAsync(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            var result = await context.Set<Client>().AddAsync(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public virtual void AddRange(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().AddRange(entities);
            context.SaveChanges();
        }

        public async virtual Task AddRangeAsync(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            await context.Set<Client>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public virtual IEnumerable<Client> GetAll()
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            return context.Set<Client>().ToList();
        }

        public async virtual Task<IEnumerable<Client>> GetAllAsync()
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            return await context.Set<Client>().ToListAsync();
        }

        public virtual Client Update(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Client>().Update(entity).Entity;
            context.SaveChanges();
            return entity;
        }

        public async virtual Task<Client> UpdateAsync(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            entity = context.Set<Client>().Update(entity).Entity;
            await context.SaveChangesAsync();
            return entity;
        }

        public virtual void UpdateRange(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().UpdateRange(entities);
            context.SaveChanges();
        }

        public async virtual Task UpdateRangeAsync(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().UpdateRange(entities);
            await context.SaveChangesAsync();
        }

        public virtual void Remove(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().Remove(entity);
            context.SaveChanges();
        }

        public async virtual Task RemoveAsync(Client entity)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public virtual void RemoveRange(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().RemoveRange(entities);
            context.SaveChanges();
        }

        public async virtual Task RemoveRangeAsync(IEnumerable<Client> entities)
        {
            using AuthClientServerDbContext context = new AuthClientServerDbContext(DbContextOptions);
            context.Set<Client>().RemoveRange(entities);
            await context.SaveChangesAsync();
        }
    }
}

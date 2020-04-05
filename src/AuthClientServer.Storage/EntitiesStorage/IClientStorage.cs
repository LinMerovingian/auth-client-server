namespace AuthClientServer.Storage
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IClientStorage
    {
        Client Add(Client entity);
        Task<Client> AddAsync(Client entity);
        void AddRange(IEnumerable<Client> entities);
        Task AddRangeAsync(IEnumerable<Client> entities);
        IEnumerable<Client> GetAll();
        Task<IEnumerable<Client>> GetAllAsync();
        Client Update(Client entity);
        Task<Client> UpdateAsync(Client entity);
        void UpdateRange(IEnumerable<Client> entities);
        Task UpdateRangeAsync(IEnumerable<Client> entities);
        void Remove(Client entity);
        Task RemoveAsync(Client entity);
        void RemoveRange(IEnumerable<Client> entities);
        Task RemoveRangeAsync(IEnumerable<Client> entities);
    }
}
